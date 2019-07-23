Templates
-------
- 템플릿 : 서로 다른 정보를 일정한 형태로 표현하기 위해 재사용 가능한 파일
- 장고 템플릿은 html을 사용

QuerySet
-------
- 쿼리셋은 전달받은 모델의 객체 목록
- 쿼리셋의 중요한 기능은 데이터 필터링
`python manage.py shell` 을 입력해 장고 쉘로 들어감

템플릿 동적 데이터
-----------
- 뷰는 모델과 템플릿을 연결하는 역할을 함
```
from django.shortcuts import render
from django.utils import timezone
from .models import Post

def post_list(request):
    posts = Post.objects.filter(published_date__lte=timezone.now()).order_by('published_date')
    return render(request, 'blog/post_list.html', {'posts': posts})
```
- posts라는 변수가 쿼리셋의 이름
- render함수의 매개변수 request와 'blog/post_list.html' 템플릿. 거기에 옵션으로 데이터가 들어있는 딕셔너리 자료형을 받음.

템플릿 태그
--------
- 브라우저는 파이썬 코드를 이해할 수 없기 때문에 html에 파이썬 코드를 바로 넣을 수 없다.
- 템플릿 태그는 파이썬 코드를 html로 바꿔준다. 
- 장고 템플릿 안에 있는 값을 출력하려면, 변수 이름 안에 중괄호를 넣어 표시해야 함.
```
{% for post in posts %}
    {{ post }}
{% endfor %}
```
for loop를 이용해 post 목록을 보여줌

