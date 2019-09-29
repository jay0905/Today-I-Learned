
재귀 알고리즘 기초
------------
- 재귀함수: 하나의 함수에서 자신을 다시 호출하여 작업을 수행하는 것
- 예: 이진 트리 (binary trees)
- 예: 자연수의 합 구하기
  
재귀 알고리즘의 효율
- Recursive version: 알고리즘의 복잡도는 O(n)
- Iterative version: 알고리즘의 복잡도 O(n) 
그러나 효율성은 재귀 알고리즘이 더 떨어진다
  
ex) 피보나치 순열
```
def solution(x):
    if x <= 1:
        return x
    answer = solution(x-1) + solution(x-2)
    return answer
```
  
재귀 알고리즘 응용
-------------
- 조합의 수 계산
	- 문제: n개의 서로 다른 원소에서 m개를 선택하는 경우의 수 
```
def combi(n, m):
	if n==m:
		return 1
	elif m==0:
		return 1
	else:
		return combi(n-1, m) + combi(n-1, m-1)
```
- 효율성 측면에서 좋은가?  
  - 알고리즘의 효율성을 생각한다면 loop를 이용하는 것이 더 좋은 방법.
  - 효율이 떨어지는데도 사용하는 이유?

- 재귀 알고리즘의 유용성
	- 문제: 하노이의 탑
	- 또한 자료구조에 있는 많은 문제들이 재귀적으로 해결될 수 있음. 
  
재귀적 이진 탐색 구현
```
def recursive(L, x, l, u):
    if l > u:
        return -1
    mid = (l + u) // 2
    if x == L[mid]:
        return mid
    elif x < L[mid]:
        return recursive(L, x, l, mid-1)

    else:
        return recursive(L, x, mid+1, u)
```
