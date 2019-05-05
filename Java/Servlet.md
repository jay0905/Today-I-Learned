Servelet
- A servlet is a small Java program that runs within a Web server. Servlets receive and respond to requests from Web clients, usually across HTTP, the HyperText Transfer Protocol.

URL 주소
- http://localhost:8080/{프로젝트이름}/{URL Mapping값}

Get Method
- 웹 브라우저가 서버에게 문서를 요청할 때 사용하는 방식
- 웹 브라우저가 GET 메서드 방식으로 요청을 보낼 때 서블릿에 doGet메서드가 호출이 된다

자바 웹 어플리케이션(Java Web Application)
- WAS에 설치(deploy)되어 동작하는 어플리케이션
- 자바 웹 어플리케이션에는 HTML, CSS, 이미지, 자바로 작성된 크래스 (Servlet도 포함됨, package, 인터페이스 등), 각종 설정 파일 등이 포함된다

자바 웹 어플리케이션의 폴더 구조
- 자바 웹 어플리케이션에는 반드시 WEB - INF라는 폴더가 존재해야 한다
- 그 안에 web.xml파일이 존재해야 한다
- 또 lib와 classes라는 폴더가 있다. lib안에는 자료, classes 안에는 java 패키지, class들, 서블릿 등

Servelet이란?
- 자바 웹 어플리케이션의 구성요소 중 동적인 처리를 하는 프로그램의 역할
- 서블릿을 정의해보면
	- 서블릿은 WAS에서 동작하는 Java 클래스이다
	- 서블릿은 HttpServlet 클래스를 상속받아야 한다
	- 서블릿과 JSP로부터 최상의 결과를 얻으려면, 웹 페이지를 개발할 때 이 두가지(JSP, 서블릿)를 조화롭게 사용해야 한다

Servlet 작성방법은 2가지로 나뉨
- Servlet 3.0 spec 이상에서 사용하는 방법
	- web.xml 파일을 사용하지 않음
	- 자바 어노테이션을 사용
	- 앞에서 실습했던 firstweb에서 사용
- Servlet 3.0 spec 미만에서 사용하는 방법
	- Servlet을 등록할 때 web.xml파일에서 등록
