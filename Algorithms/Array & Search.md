선형 배열
------------
선형 배열(Linear Arrays): 데이터가 선처럼 일렬로 늘어선 형태. python에는 서로 다른 종류의 데이터를 줄세울 수 있는 list라는 데이터형이 있다. 

python list에 활용할 수 있는 연산들
---------
리스트 길이와 관계 없이 빠른 실행 결과를 보게 되는 연산
- .append()
- .pop()

리스트 길이에 비례해서 실행 시간이 걸리는 연산들
- .insert()
- .del()


배열 - 정렬과 탐색 (Sorting & Searching)
----------
- 정렬 - 문자열로 이루어진 리스트의 경우
- 정렬 순서는 사전 순서(알파벳 순서)를 따름
- 문자열 길이 순서로 정렬하려면?
  - -> 정렬에 이용하는 키를 지정
  
- 탐색: 저장된 정보 중에서 원하는 값을 찾는 것
- 탐색 알고리즘 (1) 선형 탐색(Linear Search)
  - 리스트의 길이에 비례하는 시간 소요 -> O(n)
  - 최악의 경우 모든 원소를 다 비교해보아야 함
- 탐색 알고리즘 (2) - 이진 탐색 (Binary Search)
  - 한 번 비교가 일어날 때마다 리스트가 반씩 줄어듦 (divide & conquer) -> O(log n)
  - 이진 탐색 알고리즘(binary search algorithm) 은 정렬된 리스트를 전제로 함. 이름이 이진탐색인 이유는 1회 비교를 할 때마다 탐색 범위가 절반으로 줄어들기 때문이다. 
  
이진 탐색 코드
```
def solution(L, x):
    idx = -1
    first = 0
    last = len(L)-1
    while first <= last:
        mid = (first + last) // 2
        if L[mid] > x:
            last = mid - 1
        elif L[mid] < x:
            first = mid + 1
        else:
            idx = mid
            break
    return idx
```
