```
<짝수 3,6,9 출력>
FOR I IN 1..10 LOOP
IF MOD(I,3) = 0 THEN
DBMS_OUTPUT.PUT_LINE('출력 : ' || I);
END IF;
END LOOP;
END;
/
  
<0~4 뒤집어서 출력>
DECLARE
BEGIN
FOR I IN REVERSE 0..4 LOOP
DBMS_OUTPUT.PUT_LINE('현재 I의 값 : ' || I);
END LOOP;
END;
/
```
```
--레코드 정의 사용
DECLARE
TYPE REC_DEPT IS RECORD(
deptno NUMBER(2) NOT NULL := 99,
dname DEPT.DNAME%TYPE,
loc DEPT.LOC%TYPE);
dept_rec REC_DEPT;
BEGIN
dept_rec.deptno := 99;
dept_rec.dname := 'DATABASE';
dept_rec.loc := 'SEOUL';
DBMS_OUTPUT.PUT_LINE(dept_rec.deptno);
DBMS_OUTPUT.PUT_LINE(dept_rec.dname);
DBMS_OUTPUT.PUT_LINE(dept_rec.loc);
END;
/
  ```
  ```
  DECLARE
 V_DEPT_ROW DEPT%ROWTYPE;
 BEGIN
 SELECT DEPTNO,DNAME,LOC INTO V_DEPT_ROW FROM DEPT
 WHERE DEPTNO = 40;
DBMS_OUTPUT.PUT_LINE(V_DEPT_ROW.DEPTNO);
DBMS_OUTPUT.PUT_LINE(V_DEPT_ROW.DNAME);
DBMS_OUTPUT.PUT_LINE(V_DEPT_ROW.LOC);
 END;
 /
 
 --18-2 단일행 데이터 저장하는 커서 사용
 DECLARE
 V_DEPT_ROW DEPT%ROWTYPE;
 --명시적 커서 선언
 CURSOR C1 IS SELECT DEPTNO,DNAME,LOC FROM DEPT WHERE DEPTNO = 40;
 BEGIN
 --커서 열기
 OPEN C1;
 --데이터 가공
 FETCH C1 INTO V_DEPT_ROW;
 DBMS_OUTPUT.PUT_LINE(V_DEPT_ROW.DEPTNO);
DBMS_OUTPUT.PUT_LINE(V_DEPT_ROW.DNAME);
DBMS_OUTPUT.PUT_LINE(V_DEPT_ROW.LOC);
--커서닫기 리소스 반환
CLOSE C1;
 END;
 /
   ```
--18-3
 DECLARE
 V_DEPT_ROW DEPT%ROWTYPE;
 --명시적 커서 선언
 CURSOR c1 IS SELECT DEPTNO,DNAME,LOC FROM DEPT;
 BEGIN
 --커서 열기
 OPEN c1;
 LOOP 
 FETCH c1 INTO V_DEPT_ROW;
 --커서의 모든 행을 읽기 위해 속성 지정
 EXIT WHEN c1%NOTFOUND;
 DBMS_OUTPUT.PUT_LINE('부서번호 : ' || V_DEPT_ROW.DEPTNO || 
    '부서이름 : ' || V_DEPT_ROW.DNAME ||
    '부서위치 : ' || V_DEPT_ROW.LOC);
 END LOOP;
--커서닫기 리소스 반환
CLOSE c1;
 END;
 /
   ```
   ```
EXECUTE PRO_NOPARAM;
--익명 프로시저 실행
BEGIN
PRO_NOPARAM;
END;
/

--19-4
SELECT * FROM USER_SOURCE
WHERE NAME = 'PRO_NOPARAM';


--19-7 프로시저에 파라미터 지정하기
CREATE OR REPLACE PROCEDURE PRO_PARAM_IN(
PARAM1 IN NUMBER,
PARAM2 NUMBER,
PARAM3 NUMBER := 3,
PARAM4 NUMBER DEFAULT 4)
IS
BEGIN
DBMS_OUTPUT.PUT_LINE(PARAM1);
DBMS_OUTPUT.PUT_LINE(PARAM2);
DBMS_OUTPUT.PUT_LINE(PARAM3);
DBMS_OUTPUT.PUT_LINE(PARAM4);
END;
/
  ```
