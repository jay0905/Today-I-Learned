JDBC(Java Database Connectivity)의 정의
------------
- 자바를 이용한 데이터베이스 접속과 SQL 문장의 실행, 그리고 실행 결과로 얻어진 데이터의 핸들링을 제공하는 방법과 절차에 관한 규약
- 자바 프로그램 내에서 SQL문을 실행하기 위한 자바 API
- SQL과 프로그래밍 언어의 통합 접근 중 한 형태
- JAVA는 표준 인터페이스인 JDBC API를 제공
- 데이터베이스 벤더, 또는 기타 써드파티에서는 JDBC 인터페이스를 구현한 드라이버(driver)를 제공한다.

JDBC 클래스의 생성 관계
--------
![image](https://cphinf.pstatic.net/mooc/20180201_49/1517475141729UGWfv_PNG/2_11_1_JDBC_.PNG)

statement 생성
--------------
`Statement stmt = con.createStatement();`

질의 수행
--------
`ResultSet rs = stmt.executeQuery("select no from user");`

ResultSet으로 결과 받기
----------------------
```
ResultSet rs = stmt.executeQuery("select no from user");
while(rs.next())
	System.out.println(rs.getInt("no"));
```

