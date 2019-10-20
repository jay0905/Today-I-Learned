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
```

중위 표기법과 후위 표기법
--------
- 중위 표기법 (infix notation)  
`(A+B) * (C+D)`  
연산자가 피연산자들의 사이에 위치
- 후위 표기법 (postfix notation) 
연산자가 피연산자들의 뒤에 위치  
`AB + CD + * `

중위 표현식 -> 후위 표현식
---------
- (중위) A*B+C
- (후위) AB*C+  
여는 괄호는 스택에 push  
닫는 괄호를 만나면 여는 괄호가 나올 때까지 pop  

알고리즘의 설계
---------
연산자의 우선순위 설정
```
prec = {
	'*':3, '/':3,
	'+':2, '-':2,
	'(':`
	}
```
- 중위 표현식을 왼쪽부터 한글자씩 읽어서 피연산자이면 그냥 출력
- '('이면 스택에 push  
')'이면 '('이 나올 때까지 스택에서 pop, 출력  
- 연산자이면 스택에서 이보다 높(거나 같)은 우선순위 것들을 pop, 출력  
	- 그리고 이 연산자는 스택에 push
	- 스택에 남아있는 연산자는 모두 pop, 출력
	
증위 표현식 -> 후위 표현식 변환 함수
------------
```
class ArrayStack:

    def __init__(self):
        self.data = []

    def size(self):
        return len(self.data)

    def isEmpty(self):
        return self.size() == 0

    def push(self, item):
        self.data.append(item)

    def pop(self):
        return self.data.pop()

    def peek(self):
        return self.data[-1]

prec = {
    '*': 3, '/': 3,
    '+': 2, '-': 2,
    '(': 1
}

def solution(S):
    opStack = ArrayStack()
    answer = ''
    for c in S:
        if c.isupper():
            answer += c
        elif c == '(':
            opStack.push(c)
        elif c == ')':
            while opStack.peek() != '(':
                answer += opStack.pop()
            opStack.pop()
        else:
            if opStack.size() != 0:
                if prec[opStack.peek()] < prec[c]:
                    opStack.push(c)
                else:
                    while prec[opStack.peek()] >= prec[c]:
                        answer += opStack.pop()
                        if opStack.size() == 0:
                            break
                    opStack.push(c)
            else:
                opStack.push(c)

    while not opStack.isEmpty():
        answer += opStack.pop()

    return answer
```
