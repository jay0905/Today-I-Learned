출처: 노마드 코더 (https://academy.nomadcoders.co/courses/enrolled/216871)

- 브라우저는 빈 html을 불러오고 그 다음에 react가 html을 밀어넣는다.
- react가 빠른 이유
  - virtual DOM
  - react는 virtual이고 실제로 존재하지 않음
  
- react는 component와 함께 동작한다
  - react는 component를 사용해서 html처럼 작성하려는 경우에 필요하다 
  - react application은 한번에 하나의 component만 rendering할 수 있다 
  - component는 html을 반환하는 함수
  - jsx에서는 컴포넌트에 정보를 보낼 수 있다
  - component 재사용 가능
  
- jsx는 html + JavaScript
  
- map은 function을 취해서 그 function을 각 array의 각 item에 적용
  
- property와 method
	- 프로퍼티는 object를 위해서 데이터를 저장한다.
	- 메소드는 object가 요청 받을 수 있는 액션이다. 
  
- JSX란? 자바스크립트의 문법 확장
- JSX는 react 요소를 만든다
- 리액트에서 jsx 사용이 필수는 아님. 다만 시각적으로 더 도움 된다. 
  
- function component는 function이고 뭔가를 return, 그리고 screen에 표시
- class component는 class이지만 react componenet로부터 확장되고 screen에 표시
- state는 object
  
state와 props의 차이점
- 둘 다 javascript 객체. 두 객체 모두 렌더링 결과에 영향을 줌
- props는 함수 매개변수처럼 컴포넌트에 전달, state는 함수 내에서 선언된 변수처럼 컴포넌트 안에서 관리됨
  
- state의 상태를 변경할 때마다 react가 render function을 호출해서 바꿔주길 원함
- setState()는 컴포넌트의 state 객체의 업데이트를 실행

