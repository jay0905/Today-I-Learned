SQL
====
SQL(Structured Query Language)
----------------

- SQL은 데이터를 보다 쉽게 검색하고 추가, 삭제, 수정 같은 조작을 할 수 있도록 고안된 컴퓨터 언어
- 관계형 데이터베이스에서 데이터를 조작하고 쿼리하는 표준 수단
- DML (Data Manipulation Language): 데이터를 조작하기 위해 사용. INSERT, UPDATE, DELETE, SELECT 등이 여기에 해당.
- DDL (Data Definition Language): 데이터베이스의 스키마를 정의하거나 조작하기 위해 사용.
CREATE, DROP, ALTER 등이 여기에 해당.
- DCL (Data Control Language) : 데이터를 제어하는 언어.
권한을 관리하고, 테이터의 보안, 무결성 등을 정의.
GRANT, REVOKE 등이 여기에 해당.

> show tables
접속한 db의 테이블 목록을 보는 명령

> DESC
테이블 구조를 확인하는 명령

데이터 조작어
========

데이터 조작어의 종류
----------
- SELECT - 검색
- INSERT - 등록
- UPDATE - 수정
- DELETE - 삭제

SELECT 구문 예제(전체 데이터 검색)
----------

- 전체 데이터 검색
- SELECT 뒤에 * 를 기술함으로써 나타낼 수 있다.

SELECT 구문(함수의 사용)
---------------------
- FLOOR(x) : x보다 크지 않은 가장 큰 정수를 반환합니다. BIGINT로 자동 변환합니다.
- CEILING(x) : x보다 작지 않은 가장 작은 정수를 반환합니다.
- ROUND(x) : x에 가장 근접한 정수를 반환합니다.
- POW(x,y) POWER(x,y) : x의 y 제곱 승을 반환합니다.
- GREATEST(x,y,...) : 가장 큰 값을 반환합니다.
- LEAST(x,y,...) : 가장 작은 값을 반환합니다.
- CURDATE(),CURRENT_DATE : 오늘 날짜를 YYYY-MM-DD나 YYYYMMDD 형식으로 반환합니다.
- CURTIME(), CURRENT_TIME : 현재 시각을 HH:MM:SS나 HHMMSS 형식으로 반환합니다.
- NOW(), SYSDATE() , CURRENT_TIMESTAMP : 오늘 현시각을 YYYY-MM-DD HH:MM:SS나 YYYYMMDDHHMMSS 형식으로 반환합니다. 
- DATE_FORMAT(date,format) : 입력된 date를 format 형식으로 반환합니다.
- PERIOD_DIFF(p1,p2) : YYMM이나 YYYYMM으로 표기되는 p1과 p2의 차이 개월을 반환합니다.
