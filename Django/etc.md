```
from django import forms
from .models import City, pool, Price, Timetable, UserDate

class SaveForm(forms.ModelForm):
    class Meta:
        model = UserDate
        fields = ('user_datetime')
```

- `class Meta` : 폼을 만들기 위해 어떤 model이 쓰여야 하는지 장고에 알려줌
- 뷰에서 이 폼을 사용해 템플릿에서 보여줘야 한다
--------------
> redirect와 render의 차이점: 
- `render`는 주어진 템플릿을 주어진 context dictionay와 combine하여 rendered text와 함께 HttpResponse를 return 한다.
- `redirect`는 주어진 url로 redirect.
- `render`는 템플릿을 불러오고, `redirect`는 url로 이동한다.
------------  
- 장고에서 프로젝트란 개발 대상이 되는 전체 프로그램을 의미한다. 프로젝트를 몇 개의 기능 그룹으로 나누었을 때, 프로젝트 하위의 서브 프로그램을 어플리케이션이라고 말한다.  
- 때문에 어플리케이션을 한번만 개발하고, 이를 다른 프로젝트에 재사용하여 개발의 생산성을 높일 수 있다. 
--------------
- 장고는 웹 요청에 있는 url을 분석하고, 그 결과로 해당 url에 매핑된 뷰를 호출한다.
- 뷰는 웹 요청을 받아 데이터베이스 접속 등 해당 애플리케이션의 로직에 맞는 처리를 하고, 그 결과 데이터를 html로 변환하기 위해 템플릿 처리를 한 후에 최종 html로 된 응답 데이터를 웹 클라이언트로 반환하는 역할을 한다. 
----------------
- 장고는 폼 데이터를 처리할 때 POST 방식만을 사용한다. 
- 서버 시스템의 상태를 바꾸는 요청, 데이터베이스의 내용을 변경하는 요청은 POST 방식을 사용하고, 시스템의 상태를 바꾸지 않는 요청은 GET 방식을 사용한다. GET은 폼 데이터량이 많거나 이미지와 같은 2진 데이터를 보내는 경우에도 부적합하고 보안에도 취약하다. 
-----------------
 `forms.Form`과 `forms.ModelForm`의 차이점
- 전자는 model과 직접적으로 interact하지 않는다
- 후자는 자동적으로 생성되고 field definition을 모델 객체로부터 가져온다
----------------
- 폼을 처리하는 뷰는 2개가 필요하다. 하나는 폼을 보여주는 뷰이고, 다른 하나는 제출된 폼을 처리하는 뷰이다. 2개의 뷰는 하나의 뷰로 통합하여 처리할 수 있다. 
- 하나의 뷰에서 2가지 기능을 처리하려면 사용자에게 보여주는 폼과 제출하는 폼을 구분하여 처리할 수 있어야 한다. 장고에서는 이를 HTTP 메소드로 구분한다. 뷰가 GET방식으로 요청을 받은 경우에는 사용자에게 처음으로 폼을 보여주도록 처리하고, POST 방식으로 요청 받은 경우에는 데이터가 담긴 제출된 폼으로 간주하여 처리한다. 
