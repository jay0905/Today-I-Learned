추상적 자료구조(Abstract Data Structures)
-----------------
추상적 자료구조(Abstract Data Structures)  
- 자료구조의 내부 구조는 숨겨두고 밖에서 보이는 것을 추상적으로. 
- 밖에서 보이는 것 두 개 - Data, A set of operations
  
- Data
	- ex) 정수, 문자열, 레코드
- A set of operations
	- 삽입, 삭제, 순회...
	- 정렬, 탐색...
- 일련의 연산을 추상적으로 보여준다

기본적 연결 리스트
- 앞에 있는 것이 뒤에 있는 것을 가리키도록 연결되어있음
- 각각의 아이템을 Node라고 부른다
	- Node는 Data와 Link를 담고 있음. 
	- Node 내의 데이터는 다른 구조로 이루어질 수 있다. ex) 문자열, 레코드, 또 다른 연결리스트 등

- 리스트의 맨 앞을 Head 라고 부르고, 맨 끝 node를 tail 이라 가리킨다. 
- 왜 tail이 필요? 리스트의 맨 끝 원소에 접근할 때 유리
- 이 연결 리스트에 노드가 몇 개 있는지도 기록해두면 좋음
  
자료 구조 정의
- 먼저 노드를 만들어야 함 
```
calss Node:
	def __init__(self, item):
		self.data = item
		self.next = None

class LinkedList:
	def __init__(self):
		self.nodeCount = 0
		self.head = None
		self.tail = None
```

연산 정의
1. 특정 원소 참조 (k번째)
2. 리스트 순회
3. 길이 얻어내기
4. 원소 삽입
5. 원소 삭제
6. 두 리스트 합치기

특정 원소 참조
-----------
```
def getAt(self, pos):
	if pos <= 0 or pos > self.nodeCount:
		return None
	i = 1
	curr = self.head
	while i < pos:
		curr = curr.next
		i += 1
	return curr
```

배열과 비교한 연결 리스트  

. | 배열 | 연결리스트
--- | --- | ---
저장 공간 | 연속한 위치 | 임의의 위치
특정 원소 지칭 | 매우 간편 O(1) | 선형탐색과 유사O(n)


연결 리스트 (Linked Lists)
------------------

연결 리스트 연산 - 원소의 삽입
`def insertAt(self, pos, newNode):`
- pos -1 번째와 pos 번째 사이에 새로운 원소를 삽입해야 함

원소의 삽입 - 코드 구현
---------
```
def insertAt(self, pos, newNode)
	prev = self.getAt(pos - 1)
	newNode.next = prev.next
	prev.next = newNode
	self.nodeCount += 1
```
코드 구현 주의사항
1. 삽입하려는 위치가 리스트 맨 앞일 때
	- prev 없음
	- Head 조정 필요
2. 삽입하려는 위치가 리스트 맨 끝일 때
	- tail 조정 필요
3. 빈 리스트에 삽입할 때?
	- 두 가지 다 필요

연결 리스트 원소 삽입의 복잡도
- 맨 앞에 삽입하는 경우: O(1)
- 중간에 삽입하는 경우: O(n)
- 맨 끝에 삽입하는 경우: O(1)

연결 리스트 연산 - 원소의 삭제
----------
코드 구현 주의 사항
1. 삭제하려는 node가 맨 앞일 때
	- prev 없음
	- Head 조정 필요
2. 리스트 맨 끝의 node를 삭제할 때
	- Tail 조정 필요
3. 유일한 노드를 삭제할 때?
	- 이 두 조건에 의해 처리되는가? 어려움을 야기할 것

연결 리스트 원소 삭제의 복잡도
- 맨 앞에서 삭제하는 경우: O(1)
- 중간에서 삭제하는 경우: O(n)
- 맨 끝에서 삭제하는 경우: O(n)
	- 맨 끝에서 prev를 찾을 방법이 없으므로 앞에서부터 찾아와야 한다

연결 리스트 연산 - 두 리스트의 연결
-------------
```
def concat(self, L)::
	self.tail.next = L.head
	if L.tail:
		self.tail = L.tail
	self.nodeCount += L.nodeCount
```

연결 리스트가 힘을 발휘할 때
------------
- 스마트폰 이용하던 앱 기록, 삭제
- 삽입과 삭제가 유연하다는 것이 장점
- 그러나 현재 코드는 효율적이지 않으므로 새로운 메서드를 만들어야 한다
	- 노드를 주고 삽입하는 메서드
	- `insertAfter(prev, newNode)`
	- `popAfter(prev)` 맨 앞은?

조금 변형된 연결 리스트
-----------
- 맨 앞에 dummy node를 추가한 형태
```
class LinkedList:
	def __init__(self):
		self.nodeCount = 0
		self.head = Node(None)
		self.tail = None
		self.head.next = self.tail
```

연결 리스트 연산 - 원소의 삽입
----------------
메서드 insertAt()의 구현
`def insertAt(self, pos, newNode):`
이미 구현한 insertAfter()를 호출하여 이용하는 것으로
1. pos 범위 조건 확인
2. pos == 1인 경우에는 head 뒤에 새 node 삽입
3. pos == nodeCount + 1 인 경우는 prev <- tail
4. 그렇지 않은 경우에는 prev <- getAt(...)
  
연결 리스트 연산 - 원소의 삭제
--------------
prev의 다음 node를 삭제하고 그 node의 data를 리턴
코드 구현 주의사항
1. prev가 마지막 node일 때 (prev.next == None)
	- 삭제할 node 없음
	- return None
2. 리스트 맨 끝의 node를 삭제할 때 (curr.next == None)
	- tail 조정 필요

```
    def popAfter(self, prev):
        if prev.next == None:
            return None
        curr = prev.next
        if curr.next == None:
            self.tail = prev
        
        prev.next = curr.next
        self.nodeCount -= 1
        return curr.data

    def popAt(self, pos):
        if pos < 1 or pos > self.nodeCount:
            raise IndexError     
        prev = self.getAt(pos-1)
        return self.popAfter(prev)
```
	
연결 리스트 연산 - 두 리스트 연결
----------
```
def concat(self, L):
	self.tail.next = L.head.next
	if L.tail:
		self.tail = L.tail
	self.nodeCount += L.nodeCount
```

양방향 연결 리스트 (Double Linked Lists)
==============
- 앞으로도 (다음 node) 뒤로도 (이전 node)진행 가능
- Node 구조 확장

```
class Node:
	def __init__(self, item):
		self.data = item
		self.prev = None
		self.next = None
```
- 리스트 처음과 끝에 dummy node를 두려고 함
	- 데이터를 담고 있는 node가 모두 같은 모양
  
```
class DoublyLinkedList:
	def __init__(self, item):
		self.nodeCount = 0
		self.head = Node(None)
		self.tail = Node(None)
		self.head.prev =  None
		self.head.next = self.tail
		self.tail.prev = self.head
		self.tail.next = None
```

리스트 순회
------
```
def traverse(self):
	result = []
	curr = self.head
	while curr.next.next:
		curr = curr.next
		result.append(curr.data)
	return result
```

리스트 역순회
-----
```
def reverse(self):
	result = []
	curr = self.tail
	while curr.prev.prev:
		curr = curr.prev
		result.append(curr.data)
	return result
```

원소의 삽입
---------
```
def insertAfter(self, prev, newNode):
	next = prev.next
	newNode.prev = prev
	newNode.next = next
	prev.next = newNode
	next.prev = newNode
	self.nodeCount += 1
	return True
```
```
def insertBefore(self, next, newNode):
        prev = next.prev
        prev.next = newNode
        newNode.prev = prev
        newNode.next = next
        next.prev = newNode
        self.nodeCount += 1
        return True
```

리스트 마지막에 원소 삽입하려면? 코드 개선
-----------
```
def getAt(self, pos):
	if pos < 0 or pos > self.nodeCount:
		return None
	if pos > self.nodeCount // 2
		i = 0
		curr = self.tail
		while i < self.nodeCount - pos + 1:
			curr = curr.prev
			i += 1
	else:
		curr = curr.next
		i += 1
	return curr
```

리스트 병합
--------
```
def concat(self, L):
        self.tail.prev.next = L.head.next
        L.head.next.prev = self.tail.prev
        self.tail = L.tail
        self.nodeCount += L.nodeCount
        return self
```
