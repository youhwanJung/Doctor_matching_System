/*환자 로그인 테이블 */
CREATE TABLE PATIENT_LOGIN (
    patient_serial_number NUMBER PRIMARY KEY,
    patient_id VARCHAR2(30) UNIQUE,
    patient_password VARCHAR2(30)
);

/*환자 정보 테이블 */
CREATE TABLE PATIENT_INFO (
    patient_serial_number NUMBER PRIMARY KEY,
    patient_name VARCHAR2(20),
    patient_age INT CHECK(patient_age >= 0 AND patient_age <= 100),
    patient_gender VARCHAR2(10) CHECK(patient_gender IN ('남성', '여성')),
    patient_department VARCHAR2(30),
    patient_phone_number INT,
    patient_email VARCHAR2(100),
    patient_special_notes VARCHAR2(300),
    FOREIGN KEY (patient_serial_number) REFERENCES PATIENT_LOGIN(patient_serial_number)
);

/*환자 이미지 테이블*/
CREATE TABLE PATIENT_IMAGE (
    patient_serial_number NUMBER PRIMARY KEY,
    patient_image BLOB,
    FOREIGN KEY (patient_serial_number) REFERENCES PATIENT_INFO(patient_serial_number)
);

/*의사 이미지 테이블*/
CREATE TABLE DOCTOR_IMAGE (
    doctor_serial_number NUMBER PRIMARY KEY,
    doctor_image BLOB,
    FOREIGN KEY (doctor_serial_number) REFERENCES DOCTOR_INFO(doctor_serial_number)
);
/*병원 맵 이미지 테이블*/
CREATE TABLE HOSPITAL_MAP_IMAGE (
    hospital_serial_number NUMBER PRIMARY KEY,
    hospital_map_image BLOB,
    FOREIGN KEY ( hospital_serial_number) REFERENCES HOSPITAL_INFO(hospital_serial_number)
);


/*환자 위치 테이블*/
CREATE TABLE PATIENT_LOCATION (
    patient_serial_number NUMBER PRIMARY KEY,
    first_location VARCHAR2(50),
    second_location VARCHAR2(50),
    detailed_location VARCHAR2(50),
    FOREIGN KEY (patient_serial_number) REFERENCES PATIENT_INFO(patient_serial_number)
);

/*병원 로그인 테이블*/
CREATE TABLE HOSPITAL_LOGIN (
    hospital_serial_number NUMBER PRIMARY KEY,
    hospital_id VARCHAR2(30) UNIQUE,
    hospital_password VARCHAR2(30)
);

/*병원 정보 저장 테이블*/
CREATE TABLE HOSPITAL_INFO (
    hospital_serial_number NUMBER PRIMARY KEY,
    FOREIGN KEY (hospital_serial_number) REFERENCES HOSPITAL_LOGIN(hospital_serial_number),
    hospital_name VARCHAR2(50),
    hospital_phone_number INT,
    hospital_doctor_count NUMBER,
    hospital_special_notes VARCHAR2(500)
);

/*병원 구분 저장 테이블*/
CREATE TABLE HOSPITAL_CATEGORY (
    hospital_serial_number NUMBER PRIMARY KEY,
    hospital_category_name VARCHAR2(50),
    hospital_category_description VARCHAR2(500),
    FOREIGN KEY (hospital_serial_number) REFERENCES HOSPITAL_INFO(hospital_serial_number)
);

/*병원 위치 저장 테이블*/
CREATE TABLE HOSPITAL_LOCATION (
    hospital_serial_number NUMBER PRIMARY KEY,
    first_location VARCHAR2(50),
    second_location VARCHAR2(50),
    detailed_location VARCHAR2(50),
    FOREIGN KEY (hospital_serial_number) REFERENCES HOSPITAL_INFO(hospital_serial_number)
);

/*병상 정보저장 테이블*/
CREATE TABLE BED (
    hospital_serial_number NUMBER PRIMARY KEY,
    bed_name VARCHAR2(50),
    bed_description VARCHAR2(500)
);

/*진료과 저장 테이블*/
CREATE TABLE DEPARTMENT (
    department_serial_number NUMBER PRIMARY KEY,
    department_name VARCHAR2(50),
    department_description VARCHAR2(500)
);

/*병원 가지고있는 병동 테이블 */
CREATE TABLE HOSPITAL_BEDS (
    hospital_serial_number NUMBER REFERENCES HOSPITAL_INFO(hospital_serial_number),
    bed_serial_number NUMBER REFERENCES BED(hospital_serial_number),
    bed_quantity NUMBER,
    PRIMARY KEY (hospital_serial_number, bed_serial_number)
);

/*병원이 가지고있는 진료과*/
CREATE TABLE HOSPITAL_DEPARTMENTS (
    hospital_serial_number NUMBER REFERENCES HOSPITAL_INFO(hospital_serial_number),
    department_serial_number NUMBER REFERENCES DEPARTMENT(department_serial_number),
    PRIMARY KEY (hospital_serial_number, department_serial_number)
);

/*의사 정보 저장 테이블*/
CREATE TABLE DOCTOR_INFO (
    doctor_serial_number NUMBER PRIMARY KEY,
    doctor_name VARCHAR2(50),
    doctor_experience VARCHAR2(100),
    doctor_phone_number VARCHAR2(20),
    doctor_email VARCHAR2(100),
    doctor_primary_department VARCHAR2(30),
    doctor_introduction VARCHAR2(500),
    doctor_recommendation_count NUMBER
);

/*댓글 테이블*/
CREATE TABLE COMMENTES (
    comment_serial_number NUMBER PRIMARY KEY,
    comment_author VARCHAR2(50),
    comment_recommendation_count NUMBER,
    comment_content VARCHAR2(500)
);
/*의사가 가지고 있는 댓글 테이블 */
CREATE TABLE DOCTOR_COMMENT (
    doctor_serial_number NUMBER REFERENCES DOCTOR_INFO(doctor_serial_number),
    comment_serial_number NUMBER REFERENCES COMMENTES(comment_serial_number),
    PRIMARY KEY (doctor_serial_number, comment_serial_number)
);

/*병원이 등록한 의사 저장 테이블*/
CREATE TABLE HOSPITAL_REGISTERED_DOCTOR (
    doctor_serial_number NUMBER REFERENCES DOCTOR_INFO(doctor_serial_number),
    hospital_serial_number NUMBER REFERENCES HOSPITAL_INFO(hospital_serial_number),
    PRIMARY KEY (doctor_serial_number, hospital_serial_number)
);

/*환자의 즐겨찾기 목록 테이블*/
CREATE TABLE PATIENT_FAVORITES (
    patient_serial_number NUMBER REFERENCES PATIENT_INFO(patient_serial_number),
    doctor_serial_number NUMBER REFERENCES DOCTOR_INFO(doctor_serial_number),
    PRIMARY KEY (patient_serial_number, doctor_serial_number)
);

/*환자의 예약확인 테이블*/
CREATE TABLE PATIENT_RESERVATION_HISTORY (
    reservation_serial_number NUMBER PRIMARY KEY,
    patient_serial_number NUMBER REFERENCES PATIENT_INFO(patient_serial_number),
    doctor_serial_number NUMBER REFERENCES DOCTOR_INFO(doctor_serial_number),
    desired_reservation_date DATE,
    desired_reservation_time VARCHAR2(20),
    reservation_success_status VARCHAR2(10)
);

/*병원 메세지 저장테이블*/
CREATE TABLE HOSPITAL_MESSAGES (
    reservation_serial_number NUMBER REFERENCES PATIENT_RESERVATION_HISTORY(reservation_serial_number),
    hospital_serial_number NUMBER REFERENCES HOSPITAL_INFO(hospital_serial_number),
    PRIMARY KEY (reservation_serial_number, hospital_serial_number)
);

commit;