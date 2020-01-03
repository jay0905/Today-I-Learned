Queue
-------
- 자료(data element)를 보관할 수 있는 (선형) 구조
- 넣을 때에는 한 쪽 끝에서 밀어 넣어야 하고 -> **enqueue 연산**
- 꺼낼 때에는 반대 쪽에서 뽑아 꺼내야 하는 제약이 있음 -> dequeue 연산
- 선입선출 FIFO - First-in First-out 특징을 가짐

큐의 동작
-------
- 초기 상태: 비어 있는 큐 (empty queue)
- 데이터 원소 A를 큐에 추가
- 데이터 원소 B를 큐에 추가
- 데이터 원소 꺼내기
```
Q = Queue()
Q.enqueue(A)
Q.enqueue(B)
r1 = Q.dequeue()
r2 = Q.dequque()
```

큐의 추상적 자료구조 구현
--------
1. 배열(array)을 이용하여 구현
	- python list, method 이용
2. 연결 리스트 (linked list)를 이용하여 구현
	- 이전 강의에서 마련한 양방향 연결 리스트 이용

- 연산의 정의
	- size() - 현재 큐에 들어 있는 데이터 원소의 수를 구함
	- isEmpy() - 현재 큐가 비어 있는지를 판단
	- enqueue(x) - 데이터 원소 x를 큐에 추가 
	- dequeue() - 큐의 맨 앞에 저장된 데이터 원소를 제거 (또한, 반환)
	- peek() - 큐의 맨 앞에 저장된 데이터 원소를 반환 (제거하지 않음)

배열로 구현한 큐의 연산 복잡도
----------
- size() - O(1)
- isEmpty() - O(1)
- enqueu() - O(1)
- dequeue() - O(n)
- peek() - O(1)

환형 큐(Circular Queues)
============

큐의 활용
-----------
- 자료를 생성하는 작업과 그 자료를 이용하는 작업이 비동기적으로(asynchronously) 일어나는 경우
- 자료를 생성하는 작업이 여러 곳에서 일어나는 경우

- 자료를 생성하는 작업과 그 자료를 이용하는 작업이 양쪽 다 여러 곳에서 일어나는 경우
- 자료를 처리하여 새로운 자료를 생성하고, 나중에 그 자료를 또 처리해야 하는 작업의 경우

## Circular Queue
- Linear queue에서는 큐가 꽉 차면 dequeu를 하더라도 새 element를 넣을 수 없다. 
	- queue의 front를 옮기고 rear는 큐의 맨 뒤에 있기 때문에 
- 이를 해결하기 위해서는 새롭게 시작하기 위해 queue를 reset해야 함
- Circular queue는 마지막에 큐를 끝내는 대신 새 포지션을 시작한다
![queue](https://www.studytonight.com/data-structures/images/linear-queue-full-2.png)  
<center>(출처: studytonight)</center>

## Circular Queue의 기본 특징
1. head는 큐의 맨 앞을 가리키고, tail은 큐의 맨 끝을 가리킨다.
2. 처음 큐가 비었을 때 head와 tail은 같은 곳을 가리킨다
3. 새로 추가된 데이터는 tail이 가리켰던 위치로 추가된다. tail은 다음 위치를 가리킨다. 
4. 환형 큐에서 데이터는 실질적으로 삭제되지 않는다. dequeue가 실행될 때 head 포인터만 한 칸 증가한다. 큐 데이터는 head와 tail 사이에 있는 것만 포함되므로 그 바깥에 있는 데이터는 더이상 큐의 일부분이 되지 않는다. 
5. head와 tail은 큐의 맨 끝에 다다를 때 0으로 초기화된다.
6. head와 tail은 서로 cross할 수 있다. 즉, head pointer가 tail보다 커질 수 있다. 이는 dequeue를 몇 회 시행하고 tail이 다시 초기화 될 때 일어난다. 


우선순위 큐 (Priority Queues)
===========
Priority Queue
--------
- 큐가 FIFO 방식을 따르지 않고 원소들의 우선순위에 따라 큐에서 빠져나오는 방식

우선순위 큐의 활용
--------
- 운영체제의 CPU 스케줄러

우선순위 큐의 구현
-------
- 서로 다른 두 가지 방식
	1. Enqueueu 할 때 우선순위 순서를 유지하도록
	2. Dequeue 할 때 우선순위 높은 것을 선택
- 어느 것이 더 유리할까? 
	- 1번이 조금 더 유리하다. 
- 서로 다른 두 가지 재료
	1. 선형 배열 이용
	2. 연결 리스트 이용
- 어느 것이 더 유리할까?
	- 시간적으로는 연결 리스트.
