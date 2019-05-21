API
----
- API : Application Programming Interface
- 응용 프로그램에서 사용할 수 있도록, 운영 체제나 프로그래밍 언어가 제공하는 기능을 제어할 수 있게 만든 인터페이스

REST API
----
- REST 형식의 API
- 핵심 컨텐츠 및 기능을 외부 사이트에서 활용할 수 있도록 제공되는 인터페이스

이것은 REST가 아니다
---------
REST는 다음과 같은 스타일을 지켜야 한다
- client-server
- stateless
- cache
- uniform interface
- layered system
- code-on-demand (optional)
  
다른 것은 쉽게 구현이 가능하지만, uniform interface는 힘듦.   
  
uniform interface의 스타일
- 리소스가 URI로 식별되야 합니다.
- 리소스를 생성,수정,추가하고자 할 때 HTTP메시지에 표현을 해서 전송해야 합니다.
- 메시지는 스스로 설명할 수 있어야 합니다. (Self-descriptive message)
- 애플리케이션의 상태는 Hyperlink를 이용해 전이되야 합니다.(HATEOAS)
  
REST API는 쉽지 않기 때문에 보통은 Web API(HTTP API)를 사용한다.
