Redirect
=======
redirect
--------
- 리다이렉트는 http 프로토콜로 정해진 규칙이다
- 서버는 클라이언트로부터 요청을 받은 후, 클라이언트에게 특정 URL로 이동하라고 요청할 수 있다. 이를 리다이렉트라고 한다.
- 서버에서는 클라이언트에게 응답으로 상태코드를 302와 함께 이동할 URL 정보를 Location 헤더에 담아 전송한다. 클라이언트는 서버로부터 받은 상태값이 302이면 Location 헤더값으로 재요청을 보내게 된다. 이때 브라우저의 주소창은 전송받은 URL로 바뀌게 된다.
- 서블릿이나 jsp는 redirect하기 위해 HttpServletResponse가 가지고 있는 sendRedirect() 메소드를 사용한다

![image](https://cphinf.pstatic.net/mooc/20180127_5/1517046342330PRbSX_PNG/2_4_1_redirect__.PNG)

forward
=========
forward란?
1. 웹 브라우저에서 Servlet1에게 요청을 보냄
2. Servlet1은 요청을 처리한 후, 그 결과를 HttpServletRequest에 저장
3. Servlet1은 결과가 저장된 HttpServletRequest와 응답을 위한 HttpServletResponse를 같은 웹 어플리케이션 안에 있는 Servlet2에게 전송
4. Servlet2는 Servlet1으로 부터 받은 HttpServletRequest와 HttpServletResponse를 이용하여 요청을 처리한 후 웹 브라우저에게 결과를 전송

![image](https://cphinf.pstatic.net/mooc/20180129_279/1517202070933x0x42_PNG/2_4_2_forward.png)

servlet1이 일정한 부분만 혼자 처리하고, 나머지를 servlet2로 넘기는 작업 - forward  
마저 처리한 다음 응답을 만들어 client에게 넘김

forward와 redirect의 차이
- redirect 
  - 클라이언트가 서버에 요청을 보내고, 서버는 요청을 처리 후 클라이언트에게 새롭게 다시 요청
  - redirect 후 url 주소가 바뀜. 
- forward 
  - 서버는 클라이언트의 요청을 혼자 처리하는 것이 아니라 다른 servlet에게 맡김. 
  - 클라이언트는 요청받은 servlet1이 혼자 처리했는지 다른 서블릿에 부탁했는지 모름. -> url이 바뀌지 않음

클라이언트가 서버에게 요청을 보내면 WAS는 request와 resopnse라는 객체를 만듦.  
요청이 들어와서 응답을 할 때 까지 이 두 객체는 계속 유지됨.  
포워드는? 이 객체들이 한번만 만들어진다.
리다이렉트는? 요청이 여러번. 새로 요청이 들어오면 새로운 request와 response 객체가 만들어짐. 

