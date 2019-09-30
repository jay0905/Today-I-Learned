- 시간 복잡도 (Time Complexity)
	- 문제의 크기와 이를 해결하는데 걸리는 시간 사이의 관계
	- 우리는 data transfer "algorithm" runtime을 이와 같이 표현할 수 있다. 
	- Electronic Transfer: O(s), s는 파일의 사이즈. 전송하는 시간은 파일의 사이즈와 함께 선형으로 증가한다.  
- 공간 복잡도 (Space Complexity)
	- 문제의 크기와 이를 해결하는데 필요한 메모리 공간 사이의 관계 

- 평균 시간 복잡도 (Average Time Complexity)
	- 임의의 입력 패턴을 가정했을 때 소요되는 시간의 평균
- 최악 시간 복잡도 (Worst-case Time Complexity)
	- 가장 긴 시간을 소요하게 만드는 입력에 따라 소요되는 시간  
(참고)
우리는 알고리즘을 세 가지 다른 방식으로 표기한다
- Best Case: If all elements are equal, then quick sort will just traverse through the array once. This is O(N).
- Worst Case: What is we get really unlucky and the pivot is repeatedly the biggest element in the array? In this case, our recursion doesn't divide the array in half and recurse on each half. It just shrinks the subarray by one element.
- Expected Case: O(N log N)
-------------
- Big-O Notation
	- 점근 표기법(asymptotic notation)의 하나
	- 어떤 함수의 증가 양상을 다른 함수와의 비교로 표현 (알고리즘의 복잡도를 표현할 때 흔히 쓰임)
	- O(n) - 입력의 크기에 비례하는 시간 소요
		- 계수는 그다지 중요하지 않음
(참고)
- big omega: Omega is the equivalent concept but for lower bound. 
- big theta: Theta means both O and omega. 
Industry's meaning of big O is closer to what academics mean by theta. 

-----------
- 선형 시간 알고리즘 - O(n)
	- 예: n개의 무작위로 나열된 수에서 최댓값을 찾기 위해 선형 탐색 알고리즘 적용
	- Average case: O(n)
	- Worst case: O(n)
- 로그 시간 알고리즘 - O(logn)
	- 예: n개의 크기 순으로 정렬된 수에서 특정 값을 찾기 위해 이진 탐색 알고리즘을 적용
- 이차 시간 알고리즘 - O(n^2)
	- 예: insertion sort
- 보다 낮은 복잡도를 가지는 정렬 알고리즘
	- 예: merge sort - (nlogn)
