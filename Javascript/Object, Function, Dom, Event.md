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
