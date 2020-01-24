생활코딩 [웹브라우저와 자바스크립트](https://opentutorials.org/course/1375/6619) 강의를 들으며 정리한 내용입니다.  

## 웹브라우저와 JavaScript

html이 무엇이냐?
정보 자체. 인터넷의 역사를 놓고 봤을 때 웹이 등장했을 때 초창기의 모습. 웹 브라우저가 있고 웹서버가 있었음. 웹서버가 하는 역할은 정보를 저장하고 있다 브라우저의 요청에 따라 정보를 전달.  
  
html: 정보
css: 디자인
JavaScript: 웹브라우저, html을 프로그래밍적으로 제어
  
## Object Model
자바스크립트로 브라우저를 제어하려면 자바스크립트로 제어할 수 있는 것이 있어야 함. 그것이 바로 object. 자바스크립트로 제어할 수 있도록 브라우저의 여러 구성요소를 객체로 제공.  
object 모델은 테두리 같은 역할. 자바스크립트로 브라우저를 제어하기 위해 객체를 만드는 것은 무슨 의미? 
  
이미지가 있는 문서. 프로그래밍적으로 이것을 제어하려면 이미지 태그가 자바스크립트로 제어 가능한 형태, object여야 한다. 이 object를 누가 만듦? 브라우저에서 각각의 태그들마다 미리 객체를 만들어놓고 준비. 그 태그에 해당되는 객체를 찾아 메소드 값 등을 가져옴.  
  
이미지 태그를 제어하고 싶다면 이미지 태그에 해당하는 객체를 가져와야 함.  
브라우저가 갖고 있는 객체에는 `document`가 있음. 이건 `getElemetsByTagName`이라는 메소드가 있다.  
여기에 인자로 `img`를 가져와 return.  
배열로 return된다. 이를 가져오기 위해서는 `imgs[0]` 이미지 태그를 의미하는 객체를 가져옴.  
`imgs[0].style` 이 객체가 가지고 있는 style이라는 property를 의미.  
  
window 객체는 크게 전역객체, 또는 window나 frame과 같은 제어하기 위한 객체. 이 window 객체가 가지고 있는 property 중 중요한 것이 document.  
앞에 window를 쓰는 것과 쓰지 않는 것은 같은 의미.  
`window.document`  
  
BOM은 Brower Object Model. 현재 웹페이지가 가리키는 url을 알아낸다거나 경고창을 띄우거나 하는 것을 담당. window 객체의 property에 저장되어 있다. document처럼 window 객체의 property. document는 문서를 제어하는 중요한 역할을 하는 객체가 담겨있기에 이 property는 별도로 dom이라는 분류를 씀.  
  
또 다른 property로 javascript core가 있음. js는 이것으로 브라우저나 node.js와 같은 서버측 자바스크립트를 제어할 수 있음. 이것들은 바로 브라우저라는 호스트 환경에서는 존재하는 객체들. 그런데 각각의 언어를 제어하는 공통적인 언어는 자바스크립트. js가 자체적으로 가지고 있는 객체가 존재. array, function, date 등. js core에 해당하는 객체들은 호스트 환경이 무엇이건 공통적으로 가지고 있음.   

## BOM
Browser Object Model. 웹브라우저를 제어하기 위해 브라우저가 제공하는 객체들. 자바스크립트를 통해 브라우저의 새 창을 열거나 현재 창의 url을 알아내는 등을 할 수 있게 도와줌. 

### 전역객체 window
브라우저의 내장함수는 사실 앞에 `window.`이 붙어있는 것과 같음. 

### 사용자와 커뮤니케이션 하기
- alert
경고창은 사용자에게 정보를 제공하거나 경고, 변수에 담겨있는 값 등을 확인할 때 사용. 경고창을 한번 실행하면 확인을 누르기 전까지 다음 로직이 실행되지 않음.  
경고창을 디버깅 용도로 많이 썼지만 요즘 디버깅을 할 때는 개발자 도구가 있고 console.log를 많이 씀. 

- confirm
컨펌창을 띄워줌. 확인을 누르면 true 리턴, 취소하면 false 리턴. 

- prompt
사용자가 입력한 값을 받아 JS가 얻어낼 수 있는 기능. 

### Location 객체
현재 브라우저 창의 열려있는 문서의 url을 알려주는 객체.  
url을 알아내는 방법은 크게 두 가지   
`console.log(location.toString(), location.href);`  
첫번째 출력된 것은 toString이라 했을 때 출력된 결과. 두번째는 href라는 property에 접근했을 때 출력한 결과.  
`console.log(location);`  
로케이션 객체에 대한 정보를 보여줌.   
  
url의 정보를 의미에 따라 조각내야 하는 경우가 있음.
`console.log(location.protocol);`  
`http:`가 출력됨. 통신규약.  
`console.log(locaiton.protocol)` 을 입력하면 `https:`가 출력됨. https라는 프로토콜을 사용하고 있기 때문.    
`console.log(location.host)`: 호스트가 출력됨.   
`console.log(location.port)`: 소프트웨어를 식별하는 번호인 포트가 출력됨.  
`console.log(location.pathname)`: 웹서버가 가진 정보 중 구체적인 정보를 요청.  
`console.log(location.search)`

- url 변경하기
`location.href = "http://egoing.net";`  
현재 문서를 다른 문서로 이동.  
`location.reload()` : 웹페이지 리로드

### Navigator 객체
cross browsing.  
세상엔 다양한 브라우저가 있음. 이들의 동작방식은 w3c에서 나온 표준화 기구의 스펙에 따라 만들어짐. 업체마다 스펙에 나온 것은 비슷하게 하지만 디테일한 것은 각자의 전략에 맞춰 구현. 브라우저마다 코드가 다르게 구현될 가능성. 이것을 가능하게 해주는 것이 navigator라는 객체.  
브라우저 전쟁이 일어나게 됨. Netscape에서는 `.addEventListener`를 ㅆ는데 ie에서는 `attachEvent`를 씀. 그래서 웹표준이 생긴다. 그 중심에 navigator라는 객체가 있다.  
  
Navigator 객체가 갖고 있는 property 중 appName  
- `console.dir(navigator.appName);`  
파이어폭스는 Netscape가 나옴 (계승했기 때문). 크롬도 Netscape가 나옴.   
- `console.dir(navigator.appVersion);`
AppleWebkit - 크롬이 사용하고 있는 레이아웃 엔진. 

#### 기능 테스트
Navigator는 브라우저 호환서으 ㄹ위해 주로 사용되지만 모든 브라우저에 대응하는 것은 쉽지 않음. 그래서 기능 테스트를 사용하는 것이 더 선호되는 방법이다.  
과거에 만들어진 브라우저는 Object.keys라는 메소드가 존재하지 않음. 그래서 이것을 알려면 
```
if (!Object.keys) {
  Object.keys = (function () {
```
이런 식으로 코드를 작성해 호환성을 맞춘다. 

### 창 제어
window.open 메소드는 새 창을 생성함. 
- 첫번째 인자는 새 창에 로드할 문서의 url
`window.open('demo2.html');`
- 두 번째 인자는 새 창의 이름. _self는 스크립트가 실행되는 창
`window.open('demo2.html', '_self');`
- _blank는 새 창을 의미
`window.open('demo2.html', '_blank');`
- 세 번째 인자는 새 창의 모양과 관련된 속성이 옴  
`window.open('demo2.html', '_blank', 'width=200, resizable=yes');`
보안상 옵션은 제한하는 경우가 있음.  

### HTML Element
```
<script>
    var li = document.getElementById('active');
    console.log(li.constructor.name);
    var lis = document.getElementsByTagName('li');
    console.log(lis.constructor.name);
</script>
```
실행결과
```
HTMLLIElement 
HTMLCollection
```
- document.getElementById : 리턴 데이터 타입은 HTMLElement
- document.getElementsByTagName : 리턴 데이터 타입은 HTMLCollection

### Dom tree
모든 엘리먼트는 HTMLElement의 자식.  
HYMLElement는 Element의 자식이고 Element는 Node의 자식. Node는 Object의 자식. 이러한 관계를 DOM Tree라고 함. 

### HTML Collection
리턴 결과가 복수인 경우 사용하게 되는 객체.  
그 객체를 제거하게 되면 html에서는 제거한 순간 반영이 된다. 

## Element 객체
Element를 추상화한 객체. t라는 변수가 가리키는 객체는 html li element.  
HTMLElement라는 객체의 자식. 대표적인 특성은 style. inline css를 제어. 
이 HTMLElement는 Element라는 부모 객체가 있음.   
왜 굳이 Element라는 객체와 HTMLElement라는 객체를 구분하는 것일까?  
DOM이 HTML만을 제어하기 위한 장치가 아니다.  
마크업 언어를 제어하기 위한 규격이 DOM이기 때문에 DOM이라는 표준은 html 뿐만 아니라 XML, svg, XUL 등의 마크업 언어를 제어.  
각각의 언어는 모두 Element를 가지고 있음.  
모든 Element에 적용할 수 있는 것이 Element라는 객체에 있음.  
HTMLElement는 HTML이라는 언어에 필요한 기능을 부가적으로 추가하기 위함.  
그 중 대표적인 것이 style.  

### 식별자 API
- Element.tagName
Element라는 객체에는 tagName이라 하는 property가 있음.  
tagName은 변경되지 않는다. 
- Element.id
문서에서 id는 단 하나만 등장할 수 있는 식별자. 
- Element.className
여러 개 element를 그룹핑할 때 사용.  
자바스크립트에서는 class가 아니라 className 사용. 이름이 다를 수도 있음.  
- Element.classList
classList라는 property에 저장되어있는 객체는 DOMTokenList라는 객체. 유사배열임. 

### 조회 API
엘리먼트를 조회하는 기능.  
document.getElementsBy* 메소드를 통해 엘리먼트를 조회했음. document 객체는 문서 전체를 의미하는 엘리먼트이기에 document의 조회 메소드는 문서 전체를 대상으로 엘리먼트 조회. 

### 속성 API
태그명만으로는 부족한 부가적인 정보. 
- Element.getAttribute(name)
- Element.setAttribute(name, value)
- Element.hasAttribute(name);
- Element.removeAttribute(name);

#### 속성과 프로퍼티
- `target.setAttribute('class', 'important');
attribute 방식
- `target.className = 'important';`
property 방식
  
property 방식은 더 간편하고 속도도 빠르다.  
그러나 실제 html 속성 이름과 다른 이름을 갖는 경우가 있음. 자바스크립트의 이름 규칙 때문.  
두 방식으로 접근했을 때 값이 다를 수도 있음. 

## Node 객체
모든 DOM 객체는 Node 객체를 상속 받는다.  

### Node 관계 API
Node 객체는 Node 간의 관계 정보를 담고 있는 일련의 API를 가지고 있다.  

### 노드 종류 API
노드 작업을 하게 되면 현재 선택된 노드가 어떤 타입인지 판단해야 하는 경우가 있음.  

#### Node Type
노드의 종류에 따라 정해진 상수가 존재. 

## Document 객체
DOM의 시작점인 동시에 문서 전체를 의미하는 노드.  
이 HTMLDocument라는 객체는 문서 전체를 대표하는 객체.  
document 객체는 window 객체의 property 이다.   
  
document 객체의 주요 임무는 새로운 노드를 생성해주는 역할이다.  







