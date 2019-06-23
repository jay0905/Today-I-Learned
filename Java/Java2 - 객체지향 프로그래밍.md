출처: 생활코딩(https://opentutorials.org/course/1223)  
   

객체 지향 프로그래밍
=========
객체란? 변수와 메소드를 그룹핑한 것

클래스
------
클래스는 연관되어 있는 변수와 메소드의 집합이다.  

```class Calculator{```

인스턴스
--------
```
Calculator c1 = new Calculator();
```
- 클래스 : 설계도
- 인스턴스 : 제품
위의 코드는 new를 이용해서 만든 인스턴스를 변수 c1에 담고 있음.   

  
```
Calculator c1 = new Calculator();
c1.setOprands(10, 20);
c1.sum();       
c1.avg();       
 
Calculator c2 = new Calculator();
c2.setOprands(20, 40);
c2.sum();       
c2.avg();
```
두 개의 인스턴스를 각각 c1과 c2에 담고, 각각의 인스턴스에 속한 메소드를 호출. 

  
  
```
public void setOprands(int left, int right){
    this.left = left;
    this.right = right;
}
```
this는 클래스를 통해 만들어진 인스턴스 자신을 가리킴. 
  
  
클래스 맴버와 인스턴스 맴버
===========
클래스 변수
---------

모든 인스턴스가 공유하는 변수를 만들자
```static double PI = 3.14```
static이 붙어있으면 뒤의 변수는 static한 변수가 된다.
static을 멤버 앞에 붙이면 클래스의 멤버가 됨. 이는 모든 인스턴스에서 동일한 값이 된다는 것  
  
클래스 변수의 용도
- 인스턴스에 따라 변하지 않는 값이 필요한 경우
- 인스턴스를 생성할 필요가 없는 값을 클래스에 저장하고 싶은 경우
- 값의 변경 사항을 모든 인스턴스가 공유해야 하는 경우

클래스 메소드
----------
메소드가 인스턴스 변수를 참조하지 않는다면 클래스 메소드를 사용해서 불필요한 인스턴스의 생성을 막을 수 있다.

1. 인스턴스 메소드는 클래스 멤버에 접근할 수 있다
2. 클래스 메소드는 인스턴스 멤버에 접근할 수 없다

- 인스턴스 변수 -> Non-Static Field
- 클래스 변수 -> Static Field


