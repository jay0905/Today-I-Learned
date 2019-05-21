Web API 디자인 가이드
--------
- URI는 정보의 자원을 표현해야 한다
- 자원에 대한 행위는 HTTP Method(Get, POST, PUT, DELETE)로 표현한다

URI는 정보의 자원을 표현해야 한다.
----------
- GET /members
	- : 위의 표현은 맴버의 모든 정보를 달라는 요청.
- GET /members/delete/1
	- : GET은 정보를 요청할 때 사용. 위와 같이 동사로 삭제를 표현하면 안됨.
- DELETE /members/1
	- : HTTP Method 중의 하나인 DELETE를 이용하여 삭제를 표현해야 합니다.

슬래시 구분자(/)는 계층을 나타낼 때 사용
------------

> http://domain/houses/apartments

> http://domain/departments/1/employees

- URI 마지막 문자로 슬래시 구분자(/)를 포함하지 않는다.
- 하이픈(-)은 URI가독성을 높일 때 사용.
- 언더바(_)는 사용하지 않음.
- URI경로는 소문자만 사용.
- RFC 3986(URI 문법 형식)은 URI스키마와 호스트를 제외하고는 대소문자를 구별.
- 파일 확장자는 URI에 포함하지 않음.
- Accept Header를 사용
