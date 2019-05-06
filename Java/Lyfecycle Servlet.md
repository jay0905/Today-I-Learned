Servlet 생명주기
-----------

서블릿은 서버에 객체를 여러 개 만들지 않음
요청된 객체가 메모리에 있는지 체크하고 있으면 service라는 메서드만 호출

LyfecycleServlet
----------------
- HttpServlet의 3가지 메소드를 오버라이딩
	- init()
	- service(request, response)
	- destroy()

Servlet 생명주기
----------
- WAS는 서블릿 요청을 받으면 해당 서블릿이 메모리에 있는지 확인
- if(메모리에 없음) {
	- 해당 서블릿 클래스를 메모리에 올림
	- init() 메소드를 실행
- }
	- service()메소드를 실행
- WAS가 종료되거나, 웹 어플리케이션이 새롭게 갱신될 경우 destroy()메소드가 실행됨
  
service(request, response) 메소드
----------------
- HttpServlet의 service 메소드는 템플릿 메소드 패턴으로 구현
	- 클라이언트의 요청이 GET일 경우 자신이 가지고 있는 doGet(request response) 메소드를 호출
	- 클라이언트의 요청이 Post일 경우에는 자신이 가지고 있는 doPost(request, response)를 호출

  
실습
```
<form method='post' action='/firstweb/LifecycleServlet'>
name : <input type='text' name='name'><br>
<input type='submit' value='ok'><br>
```
- form 태그 안에 method와 action이라는 값이 있다. submit이라는 버튼이 눌렀을 때 action의 주소로 요청해달라는 뜻. 이때 method는 post라는 값으로 넣어달라. 
- URL에서 직접 요청했을 때는 메서드 값이 GET이라는 값으로 넘어감
