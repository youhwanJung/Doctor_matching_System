/*ȯ�� �α��� ���̺� */
CREATE TABLE PATIENT_LOGIN (
    patient_serial_number NUMBER PRIMARY KEY,
    patient_id VARCHAR2(30) UNIQUE,
    patient_password VARCHAR2(30)
);

/*ȯ�� ���� ���̺� */
CREATE TABLE PATIENT_INFO (
    patient_serial_number NUMBER PRIMARY KEY,
    patient_name VARCHAR2(20),
    patient_age INT CHECK(patient_age >= 0 AND patient_age <= 100),
    patient_gender VARCHAR2(10) CHECK(patient_gender IN ('����', '����')),
    patient_department VARCHAR2(30),
    patient_phone_number INT,
    patient_email VARCHAR2(100),
    patient_special_notes VARCHAR2(300),
    FOREIGN KEY (patient_serial_number) REFERENCES PATIENT_LOGIN(patient_serial_number)
);

/*ȯ�� �̹��� ���̺�*/
CREATE TABLE PATIENT_IMAGE (
    patient_serial_number NUMBER PRIMARY KEY,
    patient_image BLOB,
    FOREIGN KEY (patient_serial_number) REFERENCES PATIENT_INFO(patient_serial_number)
);

/*�ǻ� �̹��� ���̺�*/
CREATE TABLE DOCTOR_IMAGE (
    doctor_serial_number NUMBER PRIMARY KEY,
    doctor_image BLOB,
    FOREIGN KEY (doctor_serial_number) REFERENCES DOCTOR_INFO(doctor_serial_number)
);
/*���� �� �̹��� ���̺�*/
CREATE TABLE HOSPITAL_MAP_IMAGE (
    hospital_serial_number NUMBER PRIMARY KEY,
    hospital_map_image BLOB,
    FOREIGN KEY ( hospital_serial_number) REFERENCES HOSPITAL_INFO(hospital_serial_number)
);


/*ȯ�� ��ġ ���̺�*/
CREATE TABLE PATIENT_LOCATION (
    patient_serial_number NUMBER PRIMARY KEY,
    first_location VARCHAR2(50),
    second_location VARCHAR2(50),
    detailed_location VARCHAR2(50),
    FOREIGN KEY (patient_serial_number) REFERENCES PATIENT_INFO(patient_serial_number)
);

/*���� �α��� ���̺�*/
CREATE TABLE HOSPITAL_LOGIN (
    hospital_serial_number NUMBER PRIMARY KEY,
    hospital_id VARCHAR2(30) UNIQUE,
    hospital_password VARCHAR2(30)
);

/*���� ���� ���� ���̺�*/
CREATE TABLE HOSPITAL_INFO (
    hospital_serial_number NUMBER PRIMARY KEY,
    FOREIGN KEY (hospital_serial_number) REFERENCES HOSPITAL_LOGIN(hospital_serial_number),
    hospital_name VARCHAR2(50),
    hospital_phone_number INT,
    hospital_doctor_count NUMBER,
    hospital_special_notes VARCHAR2(500)
);

/*���� ���� ���� ���̺�*/
CREATE TABLE HOSPITAL_CATEGORY (
    hospital_serial_number NUMBER PRIMARY KEY,
    hospital_category_name VARCHAR2(50),
    hospital_category_description VARCHAR2(500),
    FOREIGN KEY (hospital_serial_number) REFERENCES HOSPITAL_INFO(hospital_serial_number)
);

/*���� ��ġ ���� ���̺�*/
CREATE TABLE HOSPITAL_LOCATION (
    hospital_serial_number NUMBER PRIMARY KEY,
    first_location VARCHAR2(50),
    second_location VARCHAR2(50),
    detailed_location VARCHAR2(50),
    FOREIGN KEY (hospital_serial_number) REFERENCES HOSPITAL_INFO(hospital_serial_number)
);

/*���� �������� ���̺�*/
CREATE TABLE BED (
    hospital_serial_number NUMBER PRIMARY KEY,
    bed_name VARCHAR2(50),
    bed_description VARCHAR2(500)
);

/*����� ���� ���̺�*/
CREATE TABLE DEPARTMENT (
    department_serial_number NUMBER PRIMARY KEY,
    department_name VARCHAR2(50),
    department_description VARCHAR2(500)
);

/*���� �������ִ� ���� ���̺� */
CREATE TABLE HOSPITAL_BEDS (
    hospital_serial_number NUMBER REFERENCES HOSPITAL_INFO(hospital_serial_number),
    bed_serial_number NUMBER REFERENCES BED(hospital_serial_number),
    bed_quantity NUMBER,
    PRIMARY KEY (hospital_serial_number, bed_serial_number)
);

/*������ �������ִ� �����*/
CREATE TABLE HOSPITAL_DEPARTMENTS (
    hospital_serial_number NUMBER REFERENCES HOSPITAL_INFO(hospital_serial_number),
    department_serial_number NUMBER REFERENCES DEPARTMENT(department_serial_number),
    PRIMARY KEY (hospital_serial_number, department_serial_number)
);

/*�ǻ� ���� ���� ���̺�*/
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

/*��� ���̺�*/
CREATE TABLE COMMENTES (
    comment_serial_number NUMBER PRIMARY KEY,
    comment_author VARCHAR2(50),
    comment_recommendation_count NUMBER,
    comment_content VARCHAR2(500)
);
/*�ǻ簡 ������ �ִ� ��� ���̺� */
CREATE TABLE DOCTOR_COMMENT (
    doctor_serial_number NUMBER REFERENCES DOCTOR_INFO(doctor_serial_number),
    comment_serial_number NUMBER REFERENCES COMMENTES(comment_serial_number),
    PRIMARY KEY (doctor_serial_number, comment_serial_number)
);

/*������ ����� �ǻ� ���� ���̺�*/
CREATE TABLE HOSPITAL_REGISTERED_DOCTOR (
    doctor_serial_number NUMBER REFERENCES DOCTOR_INFO(doctor_serial_number),
    hospital_serial_number NUMBER REFERENCES HOSPITAL_INFO(hospital_serial_number),
    PRIMARY KEY (doctor_serial_number, hospital_serial_number)
);

/*ȯ���� ���ã�� ��� ���̺�*/
CREATE TABLE PATIENT_FAVORITES (
    patient_serial_number NUMBER REFERENCES PATIENT_INFO(patient_serial_number),
    doctor_serial_number NUMBER REFERENCES DOCTOR_INFO(doctor_serial_number),
    PRIMARY KEY (patient_serial_number, doctor_serial_number)
);

/*ȯ���� ����Ȯ�� ���̺�*/
CREATE TABLE PATIENT_RESERVATION_HISTORY (
    reservation_serial_number NUMBER PRIMARY KEY,
    patient_serial_number NUMBER REFERENCES PATIENT_INFO(patient_serial_number),
    doctor_serial_number NUMBER REFERENCES DOCTOR_INFO(doctor_serial_number),
    desired_reservation_date DATE,
    desired_reservation_time VARCHAR2(20),
    reservation_success_status VARCHAR2(10)
);

/*���� �޼��� �������̺�*/
CREATE TABLE HOSPITAL_MESSAGES (
    reservation_serial_number NUMBER REFERENCES PATIENT_RESERVATION_HISTORY(reservation_serial_number),
    hospital_serial_number NUMBER REFERENCES HOSPITAL_INFO(hospital_serial_number),
    PRIMARY KEY (reservation_serial_number, hospital_serial_number)
);

commit;