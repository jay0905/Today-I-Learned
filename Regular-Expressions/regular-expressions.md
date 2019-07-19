```
import re // 파이썬에서 지원하는 정규식 모듈  
pattern = r'apple' //정규식 문자열 앞에는 r을 붙임  
string = 'pineapple, cherry, apple'
match = re.findall(pattern, string) // string에서 pattern에 맞는 문자열을 찾아 리스트로 반환
print(match)
```
Output: `\['apple', 'apple']`    

- \d : 숫자와 매치. \[0-9]
- \D : 숫자가 아닌 것과 매치. \[^0-9]
- \s : whitespace와 매치. \[ \t\n\r\f\v]와 동일
- \S : whitespace가 아닌 것과 매치
- \w : 문자+숫자와 매치. \[a-zA-Z0-9_]와 동일
- \W : 문자+숫자가 아닌 것과 매치
  
- \b : 단어의 경계
- \[a-zA-Z] : 영어 알파벳과 매치
  
- Dot(.) : \n을 제외한 모든 문자와 매치됨
  - `a.b` : "a + 모든 문자 + b"를 의미
  - `a[.]b` : "a + Dot문자(.) + b"
   
- 반복
  - ? : zero or one  
  - \* : zero or more  
  - \+ : one or more 
  - {m,n} : 반복횟수를 m부터 n까지 제한. 하나를 생략할 수도 있음. 
