생성자
------
```
Calculator c1 = new Calculator(10, 20)l
c1.sum();
c1.avg();
```
위와 같이 인스턴스가 생성될 때, left와 right의 값을 입력하도록 강제한다면?

클래스가 생성될 때 똑같은 이름을 가진 생성자가 실행되도록 약속됨. 같은 이름을 가진 메소드를 정의해서 그 메소드의 로직을 채워넣게 되면, 그 로직은 어떠한 메소드보다 먼저 실행되어서 초기화 작업을 하도록 한다. 

생성자의 특징
----------
- 값을 반환하지 않는다
	- 반환 값이 없기 때문에 return도 사용하지 않고, 반환 값을 메소드 정의에 포함시키지도 않는다.
- 생성자의 이름은 클래스의 이름과 동일하다

상속
=====

기존의 객체가 갖고 있던 변수 등을 물려받으면서, 새로운 것을 변경하여 사용할 수 있도록 하는 것.  
   
아래와 같은 경우에 속한다면 객체에 메소드를 추가하는 것이 어렵다.
1. 객체를 자신이 만들지 않았다. 그래서 소스를 변경할 수 없다.
2. 객체가 다용한 곳에서 활용되고 있는데 메소드를 추가하면 다른 곳에서는 불필요한 기능이 포함될 수 있다. 
  
기존의 객체를 그대로 유지하면서 기능을 추가하는 방법 - 상속  
기존의 객체는 기능을 물려준다는 의미에서 부모 객체가 되고 새로운 객체는 기존 객체의 기능을 물려받는다는 의미에서 자식 객체가 된다.   
  
부모 클래스와 자식 클래스를 상위(super) 클래스와 하위(sub)클래스라고 표현하기도 한다.  
혹은 기초 클래스(base class), 유도 클래스(derived class)라고도 한다. 

extends - 앞쪽에 있는 클래스는 뒤에 있는 클래스의 기능을 상속받게 된다. 

```
class SubstractionableCalculator extends Calculator {
    public void substract() {
        System.out.println(this.left - this.right);
    }
}
```
c1은 아래와 같이 정의하지 않은 메소드를 호출하고 있다.
```
SubstractionableCalculator c1 = new SubstractionableCalculator();
c1.setOprands(10, 20);
c1.sum();
c1.avg();
c1.substract();
```
이것이 가능한 이유는 extends Calculator 때문.    
    
상속의 장점
- 유지 보수가 쉽다
- 가독성이 높아진다
- 재활용성의 증가

상속과 생성자
========
생성자가 상속을 만나면서 발생한 복잡성 문제  
  
생성자는 객체를 생성하는 역할. 객체를 생성하는 과정에서 최초로 수행해야하는 과정을 할 수 있게함. 

```
package org.opentutorials.javatutorials.Inheritance.example4;
public class ConstructorDemo {
    public static void main(String[] args) {
        ConstructorDemo  c = new ConstructorDemo();
    }
}
```
위 예제는 에러가 발생하지 않음. ConstructorDemo 객체를 생성할 때 자동으로 생성자를 만들어주기 때문.

```
package org.opentutorials.javatutorials.Inheritance.example4;
public class ConstructorDemo {
    public ConstructorDemo(int param1) {}
    public static void main(String[] args) {
        ConstructorDemo  c = new ConstructorDemo();
    }
}
```
위 예제는 에러 발생.  
어떤 생성자가 개발자에 의해 만들어지게되면, 자바는 생성자를 암시적으로 만들어주지 않는다.  
ConstructorDemo 생성자가 호출이 되어야하는데, 자바는 그것을 자동으로 만들어주징 않음.

```
package org.opentutorials.javatutorials.Inheritance.example4;
public class ConstructorDemo {
    public ConstructorDemo(){}
    public ConstructorDemo(int param1) {}
    public static void main(String[] args) {
        ConstructorDemo  c = new ConstructorDemo();
    }
}
```

인자가 없는 기본 생성자를 명시적으로 선언. 그러면 new constructorDemo라는 생성자가 호출될 때, 명시적으로 선언해준 생성자의 정의가 실현됨. 이번 수업의 핵심을 이해하기 위한 선행학습이다. 

하위 클래스가 상위 클래스를 참조할 수 있는 방법.   
하위 클래스에서 super()를 사용. super는 부모 클래스를 의미. 괄호가 붙어있으면 부모 클래스의 생성자. 그 생성자에 값을 준다. 

