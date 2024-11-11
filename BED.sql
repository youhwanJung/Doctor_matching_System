--------------------------------------------------------
--  파일이 생성됨 - 금요일-12월-08-2023   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table BED
--------------------------------------------------------

  CREATE TABLE "JUNG02"."BED" 
   (	"HOSPITAL_SERIAL_NUMBER" NUMBER, 
	"BED_NAME" VARCHAR2(50 BYTE), 
	"BED_DESCRIPTION" VARCHAR2(500 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into JUNG02.BED
SET DEFINE OFF;
Insert into JUNG02.BED (HOSPITAL_SERIAL_NUMBER,BED_NAME,BED_DESCRIPTION) values (1,'일반입원실','일반 입원실은 일반적으로 병원이나 의료 기관에서 제공하는 기본적인 입원 시설을 의미합니다. 이는 일반적인 치료, 간호 및 관찰이 필요한 환자들을 수용하는 공간을 지칭합니다');
Insert into JUNG02.BED (HOSPITAL_SERIAL_NUMBER,BED_NAME,BED_DESCRIPTION) values (2,'중환자실','중환자실(중등도 중환자실 또는 중환자실)은 중증 환자들에게 응급 의료 서비스 및 감시를 제공하는 의료 시설입니다. 중환자실은 보다 심각한 응급 상황이나 고도의 응급 의료가 필요한 환자들을 수용합니다. 이러한 환자들은 일반적으로 심장, 호흡, 혈액 순환과 같은 기능에서 심각한 문제를 겪고 있을 수 있습니다.');
Insert into JUNG02.BED (HOSPITAL_SERIAL_NUMBER,BED_NAME,BED_DESCRIPTION) values (3,'정신과폐쇄실','정신과 폐쇄실은 정신 건강이나 특별한 상황에 있는 환자들을 수용하고 감시하기 위한 의료 시설입니다. 이러한 시설은 주로 정신 건강 상태가 위협적이거나 특별한 보호가 필요한 환자들에게 제공됩니다. 폐쇄실은 환자의 안전을 유지하고 치료 중에 필요한 관찰 및 감독을 제공하는데 사용됩니다.');
Insert into JUNG02.BED (HOSPITAL_SERIAL_NUMBER,BED_NAME,BED_DESCRIPTION) values (4,'격리병실','격리병실은 감염병이나 전염성 질환을 가진 환자를 격리하고 다른 환자들에게 전파되는 것을 방지하기 위해 사용되는 의료 시설입니다. 격리병실은 감염병이나 전염병의 환자들을 분리하여 치료하고, 감염의 확산을 방지하기 위한 특별한 보호 조치를 갖추고 있습니다.');
Insert into JUNG02.BED (HOSPITAL_SERIAL_NUMBER,BED_NAME,BED_DESCRIPTION) values (5,'무균치료실','무균치료실은 무균 상태를 유지하며 의료 절차를 수행하기 위한 의료 시설입니다. 이는 주로 수술, 치과 치료, 혈관 카테터 삽입, 중환자실에서의 치료 등과 같이 감염 위험이 높은 의료 절차를 수행할 때 사용됩니다.');
Insert into JUNG02.BED (HOSPITAL_SERIAL_NUMBER,BED_NAME,BED_DESCRIPTION) values (6,'분만실','분만실은 여성이 임신 기간 동안 산모의 분만을 지원하기 위한 의료 시설입니다. 이 공간은 산모와 산전, 산후 기간 동안 의료진이 분만 및 관련된 의료 서비스를 제공할 수 있는 특수한 공간입니다.');
Insert into JUNG02.BED (HOSPITAL_SERIAL_NUMBER,BED_NAME,BED_DESCRIPTION) values (7,'수술실','수술실은 의료 수술 및 기타 의료 절차를 수행하는 특수한 의료 시설입니다. 이는 다양한 의료 수술 및 치료 프로세스를 지원하기 위해 설계되었으며, 외과 수술, 신경외과 수술, 정형외과 수술 등 다양한 의료 분야에서 사용됩니다.');
Insert into JUNG02.BED (HOSPITAL_SERIAL_NUMBER,BED_NAME,BED_DESCRIPTION) values (8,'응급실','응급실은 응급 상황이나 긴급한 의료 상담이 필요한 환자들을 위한 의료 시설입니다. 응급실은 갑작스러운 질병, 부상, 중독, 심장 마비 등과 같은 긴급한 의료 상황에 대응하기 위해 설계되었습니다. 환자가 즉각적이고 효과적인 의료 조치를 받을 수 있도록 24시간 운영되는 공간입니다.');
Insert into JUNG02.BED (HOSPITAL_SERIAL_NUMBER,BED_NAME,BED_DESCRIPTION) values (9,'물리치료실','물리치료실은 환자들이 근육, 관절, 신경 및 운동 기능 등을 개선하고 회복하기 위해 물리치료 전문가에게 지도받는 공간입니다. 물리치료는 다양한 상황에서 환자의 기능을 향상시키기 위해 운동 치료, 근육 강화, 스트레칭, 마사지, 전기 치료, 열 치료, 냉각 치료 등의 다양한 기술을 활용합니다.');
--------------------------------------------------------
--  DDL for Index SYS_C007573
--------------------------------------------------------

  CREATE UNIQUE INDEX "JUNG02"."SYS_C007573" ON "JUNG02"."BED" ("HOSPITAL_SERIAL_NUMBER") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table BED
--------------------------------------------------------

  ALTER TABLE "JUNG02"."BED" ADD PRIMARY KEY ("HOSPITAL_SERIAL_NUMBER")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
