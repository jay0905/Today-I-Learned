트리 (Trees)
=========

트리(Tree)
-----
- node와 edge를 이용하여 데이터의 배치 형태를 추상화한 자료 구조
- root와 leaf
- 맨 위에 위치한 node가 root
- 더이상 가지를 칠 수 없는 node - leaf
- 둘 다 아닌 노드 - Internal node

Parent 노드와 Child 노드
---------
- 부모의 부모... - ancestor
- 자식의 자식... - descendant

노드의 수준 (Level)
-------
- 거쳐야 하는 간선의 수

트리의 높이 (Height)
-----
- 트리의 높이 (height) = 최대 수준(level) + 1
- 깊이 (depth)라고도 함

부분 트리 (서브트리 - Subtree)
---------
- 어느 한 노드를 기준으로 그 밑에 있는 것후손을 빼내면 subtree

노드의 차수 (Degree)
-------
- 자식(서브트리)의 수
- leaf node는 degree 0

이진 트리 (Binary Tree)
------------
- 모든 노드의 차수가 2 이하인 트리
- 재귀적으로 정의할 수 있음
	- 빈 트리 (empty tree) 이거나
	- 루트 노드 + 왼쪽 서브트리 + 오른쪽 서브트리


포화 이진 트리 (Full Binary Tree)
--------
- 모든 레벨에서 노드가 모두 채워져있는 이진 트리
- 높이가 k이고 노드의 개수가 2^k-1인 이진 트리

완전 이진 트리 (Complete Binary Tree)
------------
- 높이 k인 완전 이진 트리
- 레벨 k-2까지는 모든 노드가 2개의 자식을 가진 포와 이진 트리
- 레벨 k-1에서는 왼쪽부터 노드가 순차적으로 채워져 있는 이진 트리

이진 트리(Binary Trees)
==============
이진 트리의 추상적 자료구조
---------
연산의 정의
- size() - 현재 트리에 포함되어 있는 노드의 수를 구함
- depth() - 현재 트리의 height를 구함
- 순회 (traversal)

이진 트리의 구현 - size()
---------
전체 이진 트리의 size()  
= left subtree의 size()  
+ right subtree의 size()  
+ 1 (자기 자신)  

이진 트리의 구현 - depth()
------------
전체 이진 트리의 depth()  
= left subtree의 depth()와 right subtree의 depth()  
중 더 큰 것 + 1

이진 트리의 순회 (Traversal)
---------
- 깊이 우선 순회 (depth first traversal)
	- 중위 순회 (in-order traversal)
	- 전위 순회 (pre-order traversal)
	- 후위 순회 (post-order traversal)

중위 순회 (In-order Traversal)
-----
순회의 순서
1. left subtree
2. 자기 자신
3. right subtree

전위 순회 (Pre-order Traversal)
---------------
순회의 순서
1. 자기 자신
2. left subree
3. right subtree

후위 순회 (Post-order Traversal)
------
순회의 순서
1. Left subtree
2. Right subtree
2. 자기 자신

넓이 우선 순회 (breadth first traversal)
==========
Breadth First Traversal
--------
- 원칙
	- level이 낮은 노드를 우선으로 방문
	- 같은 수준의 노드들 사이에는, 부모 노드의 방문 순서에 따라 방문
	- 왼쪽 자식 노드를 오른쪽 자식보다 먼저 방문
- 재귀적 방법이 별로 적합하지 않음
- 한 노드를 방문했을 때
	- 나중에 방문할 노드들을 순서대로 기록해 두어야
	- 큐를 이용

넓이 우선 순회 알고리즘 구현
-------
1. (초기화) traversal <- 빈 리스트, q <- 빈 큐
2. 빈 트리가 아니면, root node를 큐에 추가 (enqueue)
3. q가 비어 있지 않은 동안
	- node <- q에서 원소를 추출 (dequeue)
	- node를 방문
4. q가 빈 큐가 되면 모든 노드 방문 완료

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
