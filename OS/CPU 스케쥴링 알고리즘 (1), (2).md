## CPU 스케줄링 알고리즘 (1)

### CPU Scheduling
- preemptive vs Non-preemptive
	- 선점 : 비선점
	- preemptive: cpu가 어떤 서비스를 실행하고 있는데 강제로 쫓아내고 다른 것이 들어갈 수 있는 방식. (ex. 응급실)
	- Non-preemptive: (ex. 은행)
- Scheduling criteria
	- CPU Utilization (CPU 이용률)
	- Throughput (처리율)
		- 단위 시간당 몇 개의 작업을 처리하는가. 주어진 시간 안에 작업을 많이 하는 것이 좋음
	- Turnaround time (반환시간)
		- 들어온 시간부터 나가는 시간까지 걸리는 시간
		- ex. 병원에 발을 들인 순간부터 진료를 끝내고 밖으로 나오는 시간까지 걸리는 시간
		- 짧을수록 좋음

	- Waiting time (대기시간)
		- cpu 서비스를 받기 전 ready Q에서 얼마나 기다렸는가
		- 짧을수록 좋음
	- Response time (응답시간)

### CPU Scheduling Algorithms
- First-Come, First-Served (FCFS)
- Shortest-Job-First (SJF)
- Priority
- Round-Robin
- Multilevel Queue
- Multilevel Feedback Queue

### First-Come, First-Served
- Simple & Fair
그러나 정말 좋은 방법인가? 꼭 좋은 성능을 나타내지만은 않음
- Example: Find Average Waiting Time
- Convoy Effect (호위 효과)
	- 따라가는 모양이 호위하는 것처럼 보임

### Shortest-job-First (1)
- Provably optimal
	- 최적으로 증명됨
- Not realistic, prediction may be needed

### Priority Scheduling (2)
- Priority
	- Internal: time limit, memory requirement, i/o to CPU burst, ...

### Round-Robin (1)
- Time-sharing system (시분할/시공유 시스템)



