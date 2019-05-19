MySQL 데이터 타입
----------
![image](https://cphinf.pstatic.net/mooc/20180131_89/1517386938999sf3SM_PNG/2_8_3_MySQL__-1.PNG)
![image](https://cphinf.pstatic.net/mooc/20180131_46/1517386952668I67cM_PNG/2_8_3_MySQL__-2.PNG)

테이블 생성
------
```
create table 테이블명( 
          필드명1 타입 [NULL | NOT NULL][DEFAULT ][AUTO_INCREMENT], 
          필드명2 타입 [NULL | NOT NULL][DEFAULT ][AUTO_INCREMENT], 
          필드명3 타입 [NULL | NOT NULL][DEFAULT ][AUTO_INCREMENT], 
          ........... 
          PRIMARY KEY(필드명) 
          );
```
- 데이터 형 외에도 속성값의 빈 값 허용 여부는 NULL 또는 NOT NULL로 설정
- DEFAULT 키워드와 함께 입력하지 않았을 때의 초기값을 지정
- 입력하지 않고 자동으로 1씩 증가하는 번호를 위한 AUTO_INCREMENT

테이블 수정(컬럼 추가/삭제)
---------
```
alter table 테이블명
          add  필드명 타입 [NULL | NOT NULL][DEFAULT ][AUTO_INCREMENT];

alter table 테이블명
         drop  필드명;
```

테이블 수정(컬럼 수정)
------
```
alter table  테이블명
     change  필드명  새필드명 타입 [NULL | NOT NULL][DEFAULT ][AUTO_INCREMENT];
```


테이블 이름 변경
```
alter table  테이블명 rename 변경이름
```
