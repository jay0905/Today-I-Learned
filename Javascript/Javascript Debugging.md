Javascript Debugging
-------------
프레임워크 없이 실행될 수 있는 것을 바닐라 JS라고 부른다.

- 디버깅 컨트롤
	- Pause, Continue : 첫 번째 버튼은 평소에는 Pause 버튼 상태인데 브렉포인트가 잡힌 상태에선 Continue 버튼이 됩니다. 다른 브레이크포인트가 잡힐 때까지 코드를 진행합니다.
	- Step over next function call : 스텝 오버는 코드 라인을 한 스탭 진행하는데 현재 실행 라인에 함수 실행 코드가 있다면 함수는 실행하는데 이때 함수 안의 코드로는 진입하지 않습니다. 즉 라인의 함수를 실행만 하게 됩니다.
	- Step into next function call : 스텝 인투는 스텝 오버와 다르게 현재 실행 라인의 코드에 함수가 있다면 함수 안의 첫 번째 코드로 진입해 들어가 다시 하나씩 라인별로 코드를 실행할 수 있습니다.
	- Step out of current function : 스텝 인투로 들어온 함수를 끝까지 실행하고 밖으로 빠져나와 해당 함수를 실행한 함수로 돌아갑니다.
	- Active/Deactive breakpoint : 브레이크포인트를 끄거나 켤 수 있습니다.
  - Pause on exception : 자바스크립트 예외가 발생하면 해당 위치에 브레이크포인트를 잡아줍니다.

