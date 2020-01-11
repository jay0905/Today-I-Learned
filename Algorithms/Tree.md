## 트리 (Trees)
- 비선형적 자료 구조 (배열, linked lists, stacks, queues는 선형적 구조)
- 트리는 root와 leaf로 이루어진다
- 더 이상 가지를 칠 수 없는 node를 leaf라고 한다
- 둘 다 아닌 노드를 internal node라고 한다
- 트리는 비어있거나 root 원소 하나일 수도 있음
- 노드가 거쳐야 하는 간선의 수를 Level이라고 한다. 
- 트리의 높이 (Height) = level + 1
- 노드의 차수 (Degree) = 자식의 수 (leaf node는 degree가 0)

![tree](https://www.i-programmer.info/images/stories/BabBag/trees/Tree1.jpg)

## 이진 트리 (Binary Tree)
- 모든 노드의 차수가 2 이하인 트리

### 포화 이진 트리 (Full Binary Tree)
- 모든 레벨에서 노드들이 모두 채워져있는 이진 트리

### 완전 이진 트리 (Complete Binary Tree)
- 마지막 레벨을 제외하고는 모든 노드가 자식 노드를 2개 가진 이진 트리
- 높이가 k일때 레벨 k-2까지는 모든 노드가 2개의 자식을 가지고 레벨 k-1부터는 왼쪽부터 노드가 순차적으로 채워짐

![trees](https://www.cs.cmu.edu/~adamchik/15-121/lectures/Trees/pix/full_complete.bmp)

## 이진 트리의 구현
### 노드
```
class Node:
	def __init__(self, item):
    	self.data = item
        self.left = None
        self.right = None
```
### 트리
```
class BinaryTree:
	def __init__(self, r):
    	self.root = r
```

### size
```
class Node: 
    def size(self):
        l = self.left.size if self.left else 0
        r = self.right.size if self.right else 0
        return l + r + 1

class BinaryTree:
	def size(self):
    	if self.root:
        	return self.root.size()
        else:
        	return 0
```

### depth
```
class Node:
	def depth(self):
    	l = self.left.depth() if self.left else 0
        r = self.right.depth() if self.right else 0
        return l+1 if l>r else r+1
        
class BinaryTree:
	def depth(self):
    	if self.root:
        	return self.root.depth()
        else:
        	return 0
```

##  이진 트리의 순회 (Traversal)

### 깊이 우선 순회
1. in-order (중위 순회): 왼쪽 자식노드(L), 내 노드(P), 오른쪽 자식노드(R) 순서로 방문한다.
2. pre-order (전위 순회): 내 노드(P), 왼쪽 자식노드(L), 오른쪽 자식노드(R) 순서로 방문한다.
3. post-order (후위 순회): 왼쪽 자식노드(L), 오른쪽 자식노드(R), 내 노드(P) 순서로 방문한다.

### 넓이 우선 순회
- level이 낮은 노드를 우선 방문
- 같은 수준의 노드들 사이에서는
	- 부모 노드의 방문 순서에 따라 방문
	- 왼쪽 자식 노드를 오른쪽 자식보다 먼저 방문 

이진 탐색 트리 (Binary Search Tree)
=======
이진 탐색 트리
------
- 모든 노드에 대해서,
	- 왼쪽 서브트리에 있는 데이터는 모두 현재 노드의 값보다 작고
	- 오른쪽 서브트리에 있는 데이터는 모두 현재 노드의 값보다 큰 성질을 만족하는 이진 트리

배열을 이용한 이진 탐색과 비교
---------
- (장점) 데이터 원소의 추가, 삭제가 용이
- (단점) 공간 소요가 큼

이진 탐색 트리의 추상적 자료구조
------------
- 데이터 표현 - 각 노드는 (key, value)의 쌍으로
- 연산의 정의
	- insert(key, data) - 트리에 주어진 데이터 원소를 추가
	- remove(key) - 특정 원소를 트리로부터 삭제
	- lookup(key) - 특정 원소를 검색
	- inorder() - 키의 순서대로 데이터 원소를 나열
	- min(), max() - 최소 키, 최대 키를 가지는 원소를 각각 탐색
	
이진 탐색 트리에서 원소 삭제
------------
1. 키를 이용해 노드를 찾는다
	- 해당 키의 노드가 없으면, 삭제할 것도 없음
	- 찾은 노드의 부모 노드도 알고 있어야 함
2. 찾은 노드를 제거하고도 이진 탐색 트리 성질을 만족하도록 트리의 구조를 정리한다. 

인터페이스의 설계
--------
입력: key
출력:
	삭제한 경우 True
	해당 키의 노드가 없는 경우 False

이진 탐색 트리 구조의 유지
--------
삭제되는 노드가
1. 말단(leaf) 노드인 경우
	- 그 노드를 없애면 됨
	- 부모 노드의 링크를 조정(좌, 우)
2. 자식을 하나 가지고 있는 경우
	- 삭제되는 노드 자리에 그 자식을 대신 배치
	- 자식이 좌? 우?
	- 부모 노드의 링크를 조정 (좌? 우?)
3. 자식을 둘 가지고 있는 경우
	- 삭제되는 노드보다 바로 다음 (큰) 키를 가지는 노드를 찾아 그 노드를 삭제되는 노드 자리에 대신 배치하고 이 노드를 대신 삭제


이진 탐색 트리가 별로 효율적이지 못한 경우
---------
```
T = BinSearchTree()
T.insert(1, 'John')
T.insert(2, 'Mary')
T.insert(3, 'Anne')
T.insert(4, 'Peter')
```
- 오른쪽으로 치우친 이진 탐색 트리  
- 혹은 왼쪽으로 치우친 이진 탐색 트리

보다 나은 성능을 보이는 이진 탐색 트리들
-------------
- 높이의 균형을 유지함으로써 O(logn)의 탐색 복잡도 보장
- 삽입, 삭제 연산이 보다 복잡

노드의 삭제 연산 구현
--------------
```
def remove(self, key):
        node, parent = self.lookup(key)
        if node:
            nChildren = node.countChildren()
	    # 삭제하려는 노드에 자식이 없는 경우
            if nChildren == 0:
	    	# 노드의 부모 노드가 있는지 없는지 판단
		# 있을 경우 해당 노드가 부모 노드의 오른쪽에 있는지 왼쪽에 있는지 분별한 후
		# 왼쪽에 있으면 부모의 왼쪽 노드를 None으로, 오른쪽이면 오른쪽 노드를 None으로 만든다
                if parent:
                    if node == parent.left:
                        parent.left = None
                    else:
                        parent.right = None
		# 부모 노드가 없을 경우(해당 노드가 루트 노드일 경우) 루트 노드를 None으로 만든다
                else:
                    self.root = None
	    # 삭제하려는 노드에 자식이 하나일 경우
            elif nChildren == 1:
	    	# 자식이 왼쪽 노드인지 오른쪽 노드인지 분별한 후 그 자식 노드를 변수로 가리킨다
                if node.left:
                    var = node.left
                else:
                    var = node.right
		# 삭제하려는 노드에 부모 노드가 있는 경우
		# 해당 노드가 부모 노드의 왼쪽 노드이면, 부모 노드의 왼쪽을 아까 가르켜둔 변수로 바꾼다
		# 오른쪽이면 오른쪽으로
                if parent:
                    if parent.left == node:
                        parent.left = var
                    else:
                        parent.right = var
		# 부모 노드가 없다면(해당 노드가 루트 노드라면) 루트 노드를 변수로 바꾼다
                else:
                    self.root = var
	    # 노드에 자식이 둘이라면
            else:
                parent = node
                successor = node.right
		# successor에 왼쪽 자식이 있는 동안은 계속 왼쪽으로 따라 내려간다
		# 순환문이 끝날 때 successor는 바로 다음 키를 가진 노드를 가리키고 parent는 그 부모 노드를 가리키도록
                while successor.left:
                    parent = successor
                    successor = successor.left
                node.key = successor.key
                node.data = successor.data
		# successor가 parent 노드의 왼쪽 자식인지 오른쪽 자식인지 판단 후
		# 왼쪽 자식일 경우에는 parent의 왼쪽 자식이 successor의 오른쪽이 되도록 (successor의 왼쪽 자식이 있을 수 없음)
                if successor == parent.left:
                    parent.left = successor.right
                else:
                    parent.right = successor.right

            return True

        else:
            return False
```
