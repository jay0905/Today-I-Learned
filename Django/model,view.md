출처: 장고걸스 튜토리얼 (출처: https://developer.mozilla.org/ko/docs/Learn/Server-side/Django)

- 모델은 객체의 한 종류. 모델을 저장하면 그 내용이 데이터베이스에 저장됨

startapp
-----
> django-admin startapp name [directory]
- 장고 앱 디렉토리 구조를 형성한다.  
- 새 디렉토리는 models.py 파일과 다른 템플릿 파일을 포함하고 있어야 한다.  
- 이 뒤에 장고에 사용한다고 알려줘야함.
  - mysite/settings.py 의 installed_apps에 `'blog,'` 추가
  
블로그 글 모델 만들기
----------
- 모든 모델 객체는 blog/models.py 파일에 선언하여 만든다
`blog/models.py`
```
from django.db import models
from django.utils import timezone


class Post(models.Model): // models는 Post가 장고 모델임을 의미
    author = models.ForeignKey('auth.User', on_delete=models.CASCADE)
    title = models.CharField(max_length=200) // CharField : 글자수가 제한된 텍스트를 정의할 때 사용
    text = models.TextField() // TextField : 글자수 제한 없는 긴 텍스트를 담을 때 사용. 블로그 본문
    created_date = models.DateTimeField( // DateTimeField : 날짜와 시간
            default=timezone.now)
    published_date = models.DateTimeField(
            blank=True, null=True)

    def publish(self):  // publish 라는 메소드
        self.published_date = timezone.now()
        self.save()

    def __str__(self):  
        return self.title  // str을 호출하면 post 모델의 제목을 리턴
```
`Foreign key` : A many to one relationship

데이터베이스에 모델을 위한 테이블 만들기
-----------------
`python manage.py makemigrations blog` : 데이터베이스에 반영할 수 있도록 migration file을 준비  
`python manage.py migrate blog` : 실제 데이터베이스에 모델 추가 반영  
**Migrations** are Django’s way of propagating changes you make to your models (adding a field, deleting a model, etc.) into your database schema. 

장고 뷰 만들기
-------
- view는 애플리케이션의 logic을 넣는 파이썬 함수
- 모델에서 필요한 정보를 받아와서 템플릿에 전달
- Web request를 받아 web response를 넘겨줌
```
def post_list(request):
    return render(request, 'blog/post_list.html', {})
```
- django.http 모듈에서 httpresponse라는 객체를 import
- post_list라는 function을 정의 - view function
- view function은 request라는 이름의 HttpRequest 객체를 첫번째 파라미터로 받음
- view function은 httpResponse라는 객체를 리턴
- render함수는 django.shortcuts 라는 모듈에 포함된 도우미 함수
  - template을 이용하여 html을 생성한 후 httpResponse에 포함해 반환
