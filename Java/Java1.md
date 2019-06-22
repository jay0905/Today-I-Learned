출처: 생활코딩(https://opentutorials.org/course/1223)

출력
----
```System.out.println(1+2);```

배열
=====
배열
-----
```
public class DefineDemo {
 
    public static void main(String[] args) {
 
        String[] classGroup = { "최진혁", "최유빈", "한이람", "이고잉" };
 
    }
 
}
```
배열을 선언할 때는 데이터 타입 뒤에 []를 붙인다. 

for-each
-----------
```
package org.opentutorials.javatutorials.array;
 
public class ForeachDemo {
 
    public static void main(String[] args) {
        String[] members = { "최진혁", "최유빈", "한이람" };
        for (String e : members) {
            System.out.println(e + "이 상담을 받았습니다");
        }
    }
 
}
`for(String e:members)`  
위 구문은 배열 members의 값을 변수 e에 담아서 중괄호 구간 안으로 전달해준다.



메소드
------
```
// 정의
public static void numbering(){
	int i = 0;
	while(i < 10) {
		System.out.println(i);
		i++;
	}
}

public static void main(String[] args) {
	numbering(); //호출
}
```

main
--------
main 메소드는 규칙이다.   
만들고 싶은 프로그램이 있다면 반드시 public static void main(String[] args) 가 이끄는 중괄호 안에 로직을 위치시켜야 한다.  
그렇게 코드를 작성하면 자바는 내가 작성한 main 메소드를 실행한다.  

매개변수와 인자
------------
메소드의 입력 값은 매개변수(parameter)를 통해서 이루어진다.
```
public class MethodDemo4 {
    public static void numbering(int limit) {
        int i = 0;
        while (i < limit) {
            System.out.println(i);
            i++;
        }
    }
 
    public static void main(String[] args) {
        numbering(5);
    }
}
```

입력과 출력
=========
string[] args
---------
string[] args는 파라미터. 파라미터는 메소드가 호출될 때 전달된 입력 값을 메소드 내부로 전달하는 변수.  
이 변수의 데이터형은 String[], 문자열을 담고 있는 배열.  

사용자의 입력을 받기
----------
자바 라이브러리 중 scanner을 이용하면 쉽게 사용자의 입력을 받을 수 있다.  
```
package org.opentutorials.javatutorials.io;
 
import java.util.Scanner;
 
public class ScannerDemo {
 
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int i = sc.nextInt();
        System.out.println(i*1000);
        sc.close();
    }
 
}
```
sc.nextInt()가 실행되면 자바는 사용자의 입력이 있을 때까지 변수 i에 값을 할당하지 않고 대기상태에 있게 된다.  
데이터를 입력하고 엔터를 누르면 i에 값이 담기고, i*1000을 한 결과가 화면에 출력된다.
