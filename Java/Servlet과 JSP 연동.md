Servlet과 JSP 연동 (forward)
==============

Servlet과 JSP 연동
- Servlet은 프로그램 로직이 수행되기에 유리하다. IDE 등에서 지원을 좀 더 잘 해준다.
- JSP는 결과를 출력하기에 Servlet보다 유리하다. 필요한 html문을 그냥 입력하면 된다.
- 프로그램 로직 수행은 Servlet, 결과 출력은 JSP에서 하는 것이 유리하다
- Servlet과 JSP의 장단점을 해결하기 위해 SErvlet에서 프로그램 로직이 수행되고, 그 결과를 JSP에게 포워딩하는 방법이 사용되게 되었다. 
이를 Servlet과 JSP연동이라 한다.
![image](https://cphinf.pstatic.net/mooc/20180129_201/1517203743283AcQbB_PNG/2_4_3_servlet_jsp.PNG)
