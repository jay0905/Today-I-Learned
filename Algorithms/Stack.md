Stack
-----
- 자료를 보관할 수 있는 (선형) 구조
- 데이터를 넣을 때는 한 쪽 끝에서 밀어 넣어야 하고 (push 연산) 꺼낼 때는 같은 쪽에서 뽑아 꺼내야 하는 제약이 있음 (pop 연산)
- 후입선출(LIFO - Last-in First-Out) 의 특징을 가짐

스택의 동작
------
- 초기 상태: empty stack  
`S = Stack()`
- 데이터 원소 A를 스택에 추가  
`S.push(A)`
- 원소 B 추가  
`S.push(B)`
- 데이터 원소 꺼내기  
`r1 = S.pop()`  
`r2 = S.pop()`   

스택에서 발생하는 오류
-----------
- 비어 있는 스택에서 데이터 원소를 꺼내려 할 때  
`r3 = S.pop()`  
-> stack underflow  
- 꽉 찬 스택에 데이터 원소를 넣으려 할 때  
-> stack overflow  

스택의 추상적 자료구조 구현
---------
1. 배열(array)을 이용하여 구현
	- python list와 method를 이용
2. linked list를 이용하여 구현
	- 양방향 연결 리스트 이용

연산의 정의
- size() - 현재 스택에 들어있는 데이터 원소의 수를 구함
- isEmpty() - 현재 스택이 비어있는지를 판단
- push(x) - 데이터 원소 x를 스택에 추가
- pop() - 스택의 맨 위에 저장된 데이터 원소를 제거 (또한 반환)
- peek() - 스택의 맨 위에 저장된 데이터 원소를 반환 (제거하지 않음) 

배열로 구현한 스택
----------
```
class ArrayStack:
	def __init__(self):
		self.data =[]

	def size(Self)
		return len(self.data)

	def isEmpty(self):
		return self.size() == 0

	def push(self, item):
		self.data.append(item)

	def pop(self):
		return self.data.pop()

	def peek(Self):
		return self.data[-1]
