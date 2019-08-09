- 뷰는 Django 어플리케이션이 특정 기능과 템플릿을 제공하는 웹페이지의 한 종류.
- 각 view는 간단한 파이썬 함수(혹은 메소드)를 사용하여 작성된다. 
- Django는 요청된 URL을 조사하여 view를 선택한다. 

뷰가 실제로 뭔가를 하도록 만들기
-------
- 각 뷰는 두 가지 중 하나를 하도록 되어 있다. 요청된 페이지의 내용이 담긴 HttpResponse 객체를 반환하거나, 혹은 Http404 같은 예외를 발생하게 해야한다. 

- 홈페이지 : 버튼과 필터가 있음
- 지역별 가까운 수영 시간을 보여줌

장고가 request를 처리하는 방법
-------------
유저가 장고 사이트로부터 페이지를 요청할 때, 어떤 파이썬 코드를 실행할지 결정하기 위해 시스템이 따르는 알고리즘이다. 

1. 장고는 root IRLconf를 결정한다. 일반적으로 이는 ROOT_URLCONF의 value이다. 그러나 만약 들어오는 HttpRequest 객체가 urlconf 속성을 가지고 있다면, value는 ROOT_URLCONF 세팅 대신 사용될 것이다. 
2. 장고는 파이썬 모듈을 불러오고 urlpatterns을 찾는다. 이는 django.urls.path() 파이썬 리스트거나 django.urls.re_path() 인스턴스여야 한다. 
3. 장고는 각각의 URL 패턴을 run through하며 요청된 url과 일치하는 것부터 멈춘다. 
4. URL 패턴 중 하나가 일치하면, 장고는 주어진 view를 import하고 call한다.

참고: https://docs.djangoproject.com/ko/2.2/intro/tutorial03/
