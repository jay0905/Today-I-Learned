출처: 노마드 코더 VanillaJs 강의

## 왜 VanillaJS인가?

Library, framework - 화장 같은 것. 배우기 쉽다.  
사람들은 어려운 바닐라 자바스크립트는 잘 모른다.   
리액트나 제이쿼리를 다룰 줄 아는 사람은 많음.   
  
일단 자바스크립트가 다른 것에 비해 훨씬 빠르다.   


자바스크립트 코드는 항상 body 밑에 있어야 한다.   


## object 
```
const info = { 
	name: "jean",
	gender:"female",
}
```

- access하는 법  
	- `console.log(info.gender);`

- 안에 있는 값은 바꿀 수 있으나 info 자체는 바꿀 수 없음.

안에 array를 담을 수도 있음
```
const info = { 
	name: "jean",
	gender:"female",
	favFood: ["Pizza", "sushi"]
}
```

## Function
```
function sayHello(name, age){
  console.log("Hello!", name, "you have", age, "years of age.");
}

sayHello("jean", 15);
```
이렇게 쓰던 것을 사람들이 싫증 내기 시작.

```
function sayHello(name, age){
  console.log(`Hello ${name} you are ${age} years old.`);
}

sayHello("jean", 15);
```
이렇게 바꿈. 

### 객체 안에 함수 사용
```
const calculator = {
	plus: function(a, b){
		return a + b;
	}
}

const plus = calculator.plus(5, 5)
console.log(plus)
```

## Modifying the DOM with JS
- querySelecotr는 노드의 첫번째 자식을 반환함
- id로 찾고 싶으면 "#title", class로 찾고 싶으면 ".title"  

## Events and event handlers
- 자바스크립트는 이벤트에 반응하기 위해서 만들어짐
- `addEventListner` 이벤트 받기를 기다린다
- `window.addEventListener("resize", handleResize);`
	- 함수에 ()를 쓰지 않는 것은 함수를 원하는 때에 호출하라는 것
	- 괄호를 쓰면 지금 당장 호출하라는 뜻이 됨

## Make your first JS App
- `setInterva(fn, 시간)`
- `querySelector`는 찾은 첫번째 것만 가져옴.
	- `querySelctorAll` 은 모든 것을 가져옴 
- local storage: 작은 자바스크립트 정보들을 저장하는 storage
- event의 preventDefault
	- 이벤트가 일어나면 root에서 일어나고 form으로 일어난다.
	- form을 제출하는 event가 발생하면, event는 document까지 계속 위로 올라감.
	- document는 다른 곳으로 간다. 프로그램 되어진 다른 곳으로 가고 새로고침 되는 것.
	- 이런 기본 행동을 막고 싶을 때 preventDefault()를 사용
- local storage에는 자바스크립트의 data를 저장할 수 없다. string만 저장할 수 있음. 
	- 그런데 `JSON.stringify`는 자바스크립트 object를 string으로 바꿔준다. 
- JSON은 'JavaScript Object Notation'의 줄임말
	- 데이터를 전달할 때, 자바스크립트가 그걸 다룰 수 있도록 object로 바꿔주는 기능
- `forEach()`: array에 담겨있는 것들 가각에 한번씩 함수를 실행시켜줌
- `document.addEventListener(event, function, useCapture)`
	- event: A string that specifies the name of the event
		- e.g. "click", "show", "toggle"...
- `.then()`
	- 기본적으로 함수를 호출. 데이터가 완전히 들어온 다음 호출한다. 
