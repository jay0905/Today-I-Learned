- 우리가 component를 만들 때마다 모든 것을 다 구현하고 싶지는 않으므로 extend from 

- react component는 render method를 가지고 있다

- react는 자동적으로 class component의 render method를 실행한다
  - class component를 이야기하는 이유는 state때문
  - state는 object이다. component의 data를 넣을 공간이 있고 이 data는 변한다.

- `<button onClick={this.add}>Add</button>`
  - add()라고 쓰지 않는 이유: ()는 '즉시'를 나타낸다. 클릭할 때만 function이 호출되기를 원하므로 쓰지 않는다. 

- state의 상태를 변경할 때 react가 render function을 호출해서 바꿔주기를 원한다
  - setState를 호출하면 react는 state를 refresh하고 render function을 호출한다 

- component를 life cycle method를 가진다
  - 그 중 하나는 mounting, 다른 것은 updating. state를 변경하는 것이 update
  - Unmounting은 component가 죽는 것. component는 페이지를 바꿀 때 죽는다. 
