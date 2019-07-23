포스트에 템플릿 링크 만들기
-----
```
<h1><a href="{% url 'post_detail' pk=post.pk %}">{{ post.title }}</a></h1>
```
- `pk=post.pk` : pk는 데이터베이스의 각 레코드를 식별하는 primary key의 준말
- 새 블로그 글이 추가될 때마다 pk라는 필드를 추가해 값이 1,2,3으로 증가

blog/urls.py
```
from django.urls import path
from . import views

urlpatterns = [
    path('', views.post_list, name='post_list'),
    path('post/<int:pk>/', views.post_detail, name='post_detail'),
]
```
- `post/` : url이 post 문자를 포함해야 함
- `<int:pk>` : 장고는 정수 값을 기대하고 이를 pk라는 변수로 뷰를 통해 전송
- `/` : 다음에 /가 한번 더 와야함
- 브라우저에 `http://127.0.0.1:8000/post/5/`를 입력하면 장고는 post_detail 뷰를 찾아가 매개변수 pk가 5인 값을 찾아 뷰로 전달

장고 폼
-------
```
from django import forms

from .models import Post

class PostForm(forms.ModelForm):

    class Meta:
        model = Post
        fields = ('title', 'text',)
```
- `forms.ModelForm` : 우리가 만들 폼이 ModelForm이라고 알려주는 구문
- `class Meta:` : 폼을 만들기 위해 어떤 model이 쓰여야 하는지 장고에 알려주는 구문 (`model = Post`)
