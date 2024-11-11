using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data; //DataSet 개체 참조
using System.Windows.Forms; 
using System.Data.SqlClient;


namespace Main
{   
    //환자의 데이터를 담을 클래스
    public class PatientData
    {
        public decimal PatientSerialNumber { get; set; }
        public string PatientName { get; set; }
        public decimal PatientAge { get; set; }
        public string PatientGender { get; set; }
        public string PatientDepartment { get; set; }
        public string PatientPhoneNumber { get; set; }
        public string PatientEmail { get; set; }
        public string PatientSpecialNotes { get; set; }
        public string FirstLocation { get; set; }
        public string SecondLocation { get; set; }
        public string DetailedLocation { get; set; }
        public byte[] PatientImage { get; set; }
    }
    //의사의 데이터를 담는 곳
    public class DoctorData
    {
        public decimal DoctorSerialNumber { get; set; }
        public string DoctorName { get; set; }
        public string DoctorExp { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorDepartment { get; set; }
        public string DoctorIntroduce { get; set; }
        public decimal DoctorRecoment { get; set; }
        public string DoctorHospital { get; set; }
        public string DoctorPhoneNum { get; set; }
        public decimal HospitalSerialNumber { get; set; }
        public string HospitalName { get; set; }
    }

    //댓글 데이터를 담는곳
    public class CommentData
    {
        public decimal Comment_PK { get; set; }
        public string CommentContent { get; set; }
        public string PatientName { get; set; }
        public int CommentRecommendationCount { get; set; }
    }
    //예약 정보 담는곳
    public class ReservationData
    {
        public decimal ReservationSerialNumber { get; set; }
        public string DesiredReservationDate { get; set; }
        public string DesiredReservationTime { get; set; }
        public string ReservationSuccessStatus { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string DoctorPrimaryDepartment { get; set; }
    }
    //즐겨찾기한 의사의 정보를 담고있음
    public class FavoriteDoctorData
    {
        public decimal PatientSerialNumber { get; set; }
        public decimal DoctorSerialNumber { get; set; }
        public string DoctorName { get; set; }
        public string DoctorExperience { get; set; }
        public string DoctorPhoneNumber { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorPrimaryDepartment { get; set; }
        public string DoctorIntroduction { get; set; }
        public decimal DoctorRecommendationCount { get; set; }
        public decimal HospitalSerialNumber { get; set; }
    }

    public class HospitalReservationData
    {
        public string PatientName { get; set; }
        public decimal PatientAge { get; set; }
        public string DoctorName { get; set; }
        public string DesiredDate { get; set; }
        public string DesiredTime { get; set; }
        public decimal RegisterSerialNumber { get; set; }
        public string Reservation_Statment { get; set; }
    }

    public class HospitalDoctorInfo
    {
        public string DoctorName { get; set; }
        public string DoctorExperience { get; set; }
        public string DoctorPrimaryDepartment { get; set; }
        public int DoctorRecommendationCount { get; set; }
        public decimal DoctorSerialNumber { get; set; }
    }

    public class HospitalData
    {
        public decimal HospitalSerialNumber { get; set; }
        public string HospitalName { get; set; }
        public string HospitalPhoneNumber { get; set; }
        public decimal HospitalDoctorCount { get; set; }
        public string HospitalSpecialNotes { get; set; }
        public string HospitalDivision { get; set; }
        public string HospitalEmail { get; set; }
        public byte[] HospitalMapImage { get; set; }
        public string FirstLocation { get; set; }
        public string SecondLocation { get; set; }
        public string DetailedLocation { get; set; }
    }

    public class DepartmentData
    {
        public decimal HospitalSerialNumber { get; set; }
        public decimal DepartmentSerialNumber { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
    }
    public class BedData
    {
        public decimal HospitalSerialNumber { get; set; }
        public string BedName { get; set; }
        public string BedDescription { get; set; }
        public decimal BedQuantity { get; set; }
        public decimal SickBedSerialNumber { get; set; }
    }

    public class Department
    {
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
    }

    public class Bed
    {
        public string BedName { get; set; }
        public string BedDescription { get; set; }
    }


    class DBconn
    {
        private string conn_info;
        List<DoctorData> DoctorDataList; 

        // 생성자 정의
        public DBconn()
        {
            conn_info = "User Id=jung02; Password=1234; Data Source=(DESCRIPTION = " +
                             "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) " +
                             "(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
        }

        //생성자 오버로딩
        public DBconn(string con_info)
        {
            conn_info = con_info;
        }

        //오라클 conection 객체 생성 
        public void OpenConnection()
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("연결 성공!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                }
            }
        }

        public String get_conn_info()
        {
            return this.conn_info;
        }

        //환자 회원가입 DB
        public Boolean patient_join_membership(String id, String pass)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO PATIENT_LOGIN (PATIENT_SERIAL_NUMBER, PATIENT_ID, PATIENT_PASSWORD) " +
                                 "VALUES (patient_login_seq.NEXTVAL, :patientId, :patientPassword)";
                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":patientId", OracleDbType.Varchar2).Value = id;
                        command.Parameters.Add(":patientPassword", OracleDbType.Varchar2).Value = pass;
                        command.ExecuteNonQuery();
                        Console.WriteLine("행이 삽입되었습니다.");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                    return false;
                }
            }
        }

        //환자 로그인 DB
        public bool patient_login(string id, string pass)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT PATIENT_ID, PATIENT_PASSWORD FROM PATIENT_LOGIN";
                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string patientId = reader.GetString(reader.GetOrdinal("PATIENT_ID"));
                                string patientPassword = reader.GetString(reader.GetOrdinal("PATIENT_PASSWORD"));

                                if (id == patientId && pass == patientPassword)
                                {
                                    return true;
                                    Console.WriteLine("로그인 성공!");
                                }
                            }
                        }
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                    Console.WriteLine("로그인 실패");
                    return false;
                }
            }
        }
        //환자의 PK값 반환
        public decimal get_patient_pk(String id, String pass)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT PATIENT_SERIAL_NUMBER FROM PATIENT_LOGIN WHERE PATIENT_ID = :id AND PATIENT_PASSWORD = :pass";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        // 매개변수 추가
                        command.Parameters.Add(":id", OracleDbType.Varchar2).Value = id;
                        command.Parameters.Add(":pass", OracleDbType.Varchar2).Value = pass;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 결과에서 값 가져오기
                                decimal PK = reader.GetDecimal(reader.GetOrdinal("PATIENT_SERIAL_NUMBER"));
                                return PK;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                }
                // 매칭되는 항목이 없으면 -1 또는 다른 적절한 값 반환
                return -1;
            }

        }

        //환자의 정보를 저장
        public int set_patient_info(decimal PK, string name, string gender, int age, string department, string phone, string special_note, string e_mail)
        { 
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO JUNG02.PATIENT_INFO " +
                         "(PATIENT_SERIAL_NUMBER, PATIENT_NAME, PATIENT_AGE, PATIENT_GENDER, " +
                         "PATIENT_DEPARTMENT, PATIENT_PHONE_NUMBER, PATIENT_EMAIL, PATIENT_SPECIAL_NOTES) " +
                         "VALUES (:patientSerialNumber, :name, :age, :gender, :department, :phoneNumber, :email, :specialNotes)";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {

                        cmd.Parameters.Add(":patientSerialNumber", OracleDbType.Decimal).Value = PK;
                        cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                        cmd.Parameters.Add(":age", OracleDbType.Int32).Value = age;
                        cmd.Parameters.Add(":gender", OracleDbType.Varchar2).Value = gender;
                        cmd.Parameters.Add(":department", OracleDbType.Varchar2).Value = department;
                        cmd.Parameters.Add(":phoneNumber", OracleDbType.Varchar2).Value = phone;
                        cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = e_mail;
                        cmd.Parameters.Add(":specialNotes", OracleDbType.Varchar2).Value = special_note;

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("환자 정보 행을 삽입합니다.");
                    }
                    return 1;
                }
                catch (OracleException ex)
                {
                    if (ex.Number == 1)
                    {
                        return 2;
                    }
                    else
                    {
                        Console.WriteLine("연결 실패: " + ex.Message);
                        return -1;
                    }
                }
            }
        }
        //환자의 정보를 이전에 저장했는지 확인
        public bool before_login_check(decimal patientSerialNumber)
        {
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT COUNT(*) FROM JUNG02.PATIENT_INFO WHERE PATIENT_SERIAL_NUMBER = :patientSerialNumber";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(":patientSerialNumber", OracleDbType.Decimal).Value = patientSerialNumber;

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 쿼리 실행 중 오류: " + ex.Message);
                    return false;
                }
            }
        }

        //환자의 위치를 저장
        public Boolean set_patient_location(decimal PK, string firstLocation, string secondLocation, string detailedLocation)
        {
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO JUNG02.PATIENT_LOCATION " +
                                 "(PATIENT_SERIAL_NUMBER, FIRST_LOCATION, SECOND_LOCATION, DETAILED_LOCATION) " +
                                 "VALUES (:patientSerialNumber, :firstLocation, :secondLocation, :detailedLocation)";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(":patientSerialNumber", OracleDbType.Decimal).Value = PK;
                        cmd.Parameters.Add(":firstLocation", OracleDbType.Varchar2).Value = firstLocation;
                        cmd.Parameters.Add(":secondLocation", OracleDbType.Varchar2).Value = secondLocation;
                        cmd.Parameters.Add(":detailedLocation", OracleDbType.Varchar2).Value = detailedLocation;

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("환자 위치 행을 삽입합니다.");
                       return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 쿼리 실행 중 오류: " + ex.Message);
                    return false;
                }
            }
        }
        //환자의 데이터를 리스트에저장
        public PatientData get_patient_data(decimal patientSerialNumber)
        {
            PatientData patientData = new PatientData();

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT PI.PATIENT_SERIAL_NUMBER, " +
                        "       PI.PATIENT_NAME, " +
                        "       PI.PATIENT_AGE, " +
                        "       PI.PATIENT_GENDER, " +
                        "       PI.PATIENT_DEPARTMENT, " +
                        "       PI.PATIENT_PHONE_NUMBER, " +
                        "       PI.PATIENT_EMAIL, " +
                        "       PI.PATIENT_SPECIAL_NOTES, " +
                        "       PL.FIRST_LOCATION, " +
                        "       PL.SECOND_LOCATION, " +
                        "       PL.DETAILED_LOCATION, " +
                        "       IMG.PATIENT_IMAGE " +
                        "FROM JUNG02.PATIENT_INFO PI " +
                        "JOIN JUNG02.PATIENT_LOCATION PL ON PI.PATIENT_SERIAL_NUMBER = PL.PATIENT_SERIAL_NUMBER " +
                        "LEFT JOIN JUNG02.PATIENT_IMAGE IMG ON PI.PATIENT_SERIAL_NUMBER = IMG.PATIENT_SERIAL_NUMBER " +
                        "WHERE PI.PATIENT_SERIAL_NUMBER = :patientSerialNumber";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(":patientSerialNumber", OracleDbType.Decimal).Value = patientSerialNumber;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                patientData.PatientSerialNumber = reader.GetDecimal(0);
                                patientData.PatientName = reader.GetString(1);
                                patientData.PatientAge = reader.GetDecimal(2);
                                patientData.PatientGender = reader.GetString(3);
                                patientData.PatientDepartment = reader.GetString(4);
                                patientData.PatientPhoneNumber = reader.GetString(5);
                                patientData.PatientEmail = reader.GetString(6);
                                patientData.PatientSpecialNotes = reader.GetString(7);
                                patientData.FirstLocation = reader.GetString(8);
                                patientData.SecondLocation = reader.GetString(9);
                                patientData.DetailedLocation = reader.GetString(10);
                                byte[] imageBytes = (byte[])reader["PATIENT_IMAGE"];
                                patientData.PatientImage = imageBytes;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 쿼리 실행 중 오류: " + ex.Message);
                }
            }
            return patientData;
        }

        //환자가 정보를 변경할 환자의 정보를 업데이트
        public void update_patient_info(decimal patientSerialNumber, PatientData updatedData)
        {
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string updateSql = "UPDATE JUNG02.PATIENT_INFO SET " +
                                       "PATIENT_NAME = :patientName, " +
                                       "PATIENT_AGE = :patientAge, " +
                                       "PATIENT_GENDER = :patientGender, " +
                                       "PATIENT_DEPARTMENT = :patientDepartment, " +
                                       "PATIENT_PHONE_NUMBER = :patientPhoneNumber, " +
                                       "PATIENT_EMAIL = :patientEmail, " +
                                       "PATIENT_SPECIAL_NOTES = :patientSpecialNotes " +
                                       "WHERE PATIENT_SERIAL_NUMBER = :patientSerialNumber";
                    //환자 정보 업데이트
                    using (OracleCommand updateCmd = new OracleCommand(updateSql, conn))
                    {
                        updateCmd.Parameters.Add(":patientName", OracleDbType.Varchar2).Value = updatedData.PatientName;
                        updateCmd.Parameters.Add(":patientAge", OracleDbType.Decimal).Value = updatedData.PatientAge;
                        updateCmd.Parameters.Add(":patientGender", OracleDbType.Varchar2).Value = updatedData.PatientGender;
                        updateCmd.Parameters.Add(":patientDepartment", OracleDbType.Varchar2).Value = updatedData.PatientDepartment;
                        updateCmd.Parameters.Add(":patientPhoneNumber", OracleDbType.Varchar2).Value = updatedData.PatientPhoneNumber;
                        updateCmd.Parameters.Add(":patientEmail", OracleDbType.Varchar2).Value = updatedData.PatientEmail;
                        updateCmd.Parameters.Add(":patientSpecialNotes", OracleDbType.Varchar2).Value = updatedData.PatientSpecialNotes;
                        updateCmd.Parameters.Add(":patientSerialNumber", OracleDbType.Decimal).Value = patientSerialNumber;

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        Console.WriteLine($"업데이트된 행 수: {rowsAffected}");
                    }

                    string updateLocationSql = "UPDATE JUNG02.PATIENT_LOCATION SET " +
                                       "FIRST_LOCATION = :firstLocation, " +
                                       "SECOND_LOCATION = :secondLocation, " +
                                       "DETAILED_LOCATION = :detailedLocation " +
                                       "WHERE PATIENT_SERIAL_NUMBER = :patientSerialNumber";
                    //환자 위치 업데이트
                    using (OracleCommand updateLocationCmd = new OracleCommand(updateLocationSql, conn))
                    {
                        updateLocationCmd.Parameters.Add(":firstLocation", OracleDbType.Varchar2).Value = updatedData.FirstLocation;
                        updateLocationCmd.Parameters.Add(":secondLocation", OracleDbType.Varchar2).Value = updatedData.SecondLocation;
                        updateLocationCmd.Parameters.Add(":detailedLocation", OracleDbType.Varchar2).Value = updatedData.DetailedLocation;
                        updateLocationCmd.Parameters.Add(":patientSerialNumber", OracleDbType.Decimal).Value = patientSerialNumber;

                        int locationRowsAffected = updateLocationCmd.ExecuteNonQuery();

                        Console.WriteLine($"위치 정보 업데이트된 행 수: {locationRowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 쿼리 실행 중 오류: " + ex.Message);
                }
            }
        }
        //환자의 정보에 맞게 의사PK 찾음
        public List<decimal> doctor_search(PatientData patient_data)
        {
            List<decimal> doctorPKList = new List<decimal>();

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = @"
                    SELECT
                        DI.DOCTOR_SERIAL_NUMBER AS DOCTOR_PK
                    FROM
                        JUNG02.HOSPITAL_LOCATION HL
                    JOIN
                        JUNG02.HOSPITAL_INFO HI ON HL.HOSPITAL_SERIAL_NUMBER = HI.HOSPITAL_SERIAL_NUMBER
                    JOIN
                        JUNG02.DOCTOR_INFO DI ON HI.HOSPITAL_SERIAL_NUMBER = DI.HOSPITAL_SERIAL_NUMBER
                    WHERE
                        HL.FIRST_LOCATION = :FirstLocation
                        AND HL.SECOND_LOCATION = :SecondLocation
                        AND DI.DOCTOR_PRIMARY_DEPARTMENT = :DoctorDepartment";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add("FirstLocation", OracleDbType.Varchar2).Value = patient_data.FirstLocation;
                        cmd.Parameters.Add("SecondLocation", OracleDbType.Varchar2).Value = patient_data.SecondLocation;
                        cmd.Parameters.Add("DoctorDepartment", OracleDbType.Varchar2).Value = patient_data.PatientDepartment;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal doctorPK = reader.GetDecimal(reader.GetOrdinal("DOCTOR_PK"));
                                doctorPKList.Add(doctorPK);
                            }

                            if (doctorPKList.Count == 0)
                            {
                                Console.WriteLine("의사 찾는 의사가 없습니다.");
                            }
                            else
                            {
                                Console.WriteLine("의사 찾기 성공!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 쿼리 실행 중 오류: " + ex.Message);
                }
            }
            return doctorPKList;
        }
        //의사의 PK값을 받고 의사데이터를 담는 객체에 정보를 저장, 그리고 List에 그 객체들을 담음
        public List<DoctorData> GetDoctor_List(List<decimal> doctorPKList)
        {
            this.DoctorDataList = new List<DoctorData>();

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = @"
                                SELECT
                                DI.DOCTOR_SERIAL_NUMBER AS DOCTOR_PK,
                                DI.DOCTOR_NAME,
                                DI.DOCTOR_EXPERIENCE,
                                DI.DOCTOR_EMAIL,
                                DI.DOCTOR_PRIMARY_DEPARTMENT,
                                DI.DOCTOR_INTRODUCTION,
                                DI.DOCTOR_RECOMMENDATION_COUNT,
                                DI.DOCTOR_PHONE_NUMBER,
                                HI.HOSPITAL_NAME AS DOCTOR_HOSPITAL,
                                DI.HOSPITAL_SERIAL_NUMBER  -- 쉼표가 누락되어 있었습니다.
                                FROM
                                    JUNG02.DOCTOR_INFO DI
                                JOIN
                                    JUNG02.HOSPITAL_INFO HI ON DI.HOSPITAL_SERIAL_NUMBER = HI.HOSPITAL_SERIAL_NUMBER
                                WHERE
                                    DI.DOCTOR_SERIAL_NUMBER = :DoctorPK";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        foreach (decimal doctorPK in doctorPKList)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("DoctorPK", OracleDbType.Decimal).Value = doctorPK;

                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    DoctorData doctorData = new DoctorData
                                    {
                                        DoctorSerialNumber = reader.GetDecimal(reader.GetOrdinal("DOCTOR_PK")),
                                        DoctorName = reader.GetString(reader.GetOrdinal("DOCTOR_NAME")),
                                        DoctorExp = reader.GetString(reader.GetOrdinal("DOCTOR_EXPERIENCE")),
                                        DoctorEmail = reader.GetString(reader.GetOrdinal("DOCTOR_EMAIL")),
                                        DoctorDepartment = reader.GetString(reader.GetOrdinal("DOCTOR_PRIMARY_DEPARTMENT")),
                                        DoctorIntroduce = reader.GetString(reader.GetOrdinal("DOCTOR_INTRODUCTION")),
                                        DoctorRecoment = reader.GetDecimal(reader.GetOrdinal("DOCTOR_RECOMMENDATION_COUNT")),
                                        DoctorHospital = reader.GetString(reader.GetOrdinal("DOCTOR_HOSPITAL")),
                                        DoctorPhoneNum = reader.GetString(reader.GetOrdinal("DOCTOR_PHONE_NUMBER")),
                                        HospitalSerialNumber = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_SERIAL_NUMBER"))
                                    };

                                    DoctorDataList.Add(doctorData);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 쿼리 실행 중 오류: " + ex.Message);
                }
            }

            return DoctorDataList;
        }

        //댓글 작성 쿼리
        public void input_comment(decimal Patient_PK, decimal Doctor_PK, string content)
        {
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("INSERT INTO JUNG02.COMMENTES " +
                                                                 "(COMMENT_SERIAL_NUMBER, COMMENT_RECOMMENDATION_COUNT, " +
                                                                 "COMMENT_CONTENT, PATIENT_SERAIL_NUMBER, DOCTOR_SERIAL_NUMBER) " +
                                                                 "VALUES (COMMENT_SEQ.NEXTVAL, :recommendationCount, " +
                                                                 ":commentContent, :patientSerialNumber, :doctorSerialNumber)", conn))
                    {
                        cmd.Parameters.Add("recommendationCount", OracleDbType.Decimal).Value = 0;
                        cmd.Parameters.Add("commentContent", OracleDbType.Varchar2).Value = content;
                        cmd.Parameters.Add("patientSerialNumber", OracleDbType.Decimal).Value = Patient_PK;
                        cmd.Parameters.Add("doctorSerialNumber", OracleDbType.Decimal).Value = Doctor_PK;

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("데이터가 성공적으로 삽입되었습니다.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"데이터 삽입 중 오류: {ex.Message}");
                }
            }
        }

        //의사 댓글을 보여주는 쿼리
        public List<CommentData> Show_DoctorComment(decimal DoctorPK)
        {
            List<CommentData> comments = new List<CommentData>();

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                conn.Open();

                string sql = @"
            SELECT
                C.COMMENT_SERIAL_NUMBER,
                C.COMMENT_CONTENT,
                P.PATIENT_NAME,
                C.COMMENT_RECOMMENDATION_COUNT
            FROM
                JUNG02.COMMENTES C
            JOIN
                JUNG02.PATIENT_INFO P ON C.PATIENT_SERAIL_NUMBER = P.PATIENT_SERIAL_NUMBER
            WHERE
                C.DOCTOR_SERIAL_NUMBER = :DoctorSerialNumber";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("DoctorSerialNumber", OracleDbType.Decimal).Value = DoctorPK;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CommentData comment = new CommentData
                            {
                                Comment_PK = Convert.ToInt32(reader["COMMENT_SERIAL_NUMBER"]),
                                CommentContent = reader["COMMENT_CONTENT"].ToString(),
                                PatientName = reader["PATIENT_NAME"].ToString(),
                                CommentRecommendationCount = Convert.ToInt32(reader["COMMENT_RECOMMENDATION_COUNT"])
                            };

                            comments.Add(comment);
                        }
                    }
                }
            }
            return comments;
        }
        //예약을 하는 쿼리
        public void input_reservation(decimal PationPK, decimal DoctorPK, string date, string time)
        {
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = @"
                INSERT INTO JUNG02.PATIENT_RESERVATION_HISTORY
                (RESERVATION_SERIAL_NUMBER, PATIENT_SERIAL_NUMBER, DOCTOR_SERIAL_NUMBER, DESIRED_RESERVATION_DATE, DESIRED_RESERVATION_TIME, RESERVATION_SUCCESS_STATUS)
                VALUES
                (RESERVATION_SEQ.NEXTVAL, :PatientSerialNumber, :DoctorSerialNumber, :DesiredReservationDate, :DesiredReservationTime, :ReservationSuccessStatus)";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add("PatientSerialNumber", OracleDbType.Decimal).Value = PationPK;
                        cmd.Parameters.Add("DoctorSerialNumber", OracleDbType.Decimal).Value = DoctorPK;
                        cmd.Parameters.Add("DesiredReservationDate", OracleDbType.Varchar2).Value = date;
                        cmd.Parameters.Add("DesiredReservationTime", OracleDbType.Varchar2).Value = time;
                        cmd.Parameters.Add("ReservationSuccessStatus", OracleDbType.Varchar2).Value = "심사중";

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("예약 기록이 추가되었습니다.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("예약 기록 추가 중 오류: " + ex.Message);
                }
            }
        }

        //환자의 예약 내역을 환자가 볼 수 있도록 하는 쿼리
        public List<ReservationData> GetPatientReservations(decimal patientSerialNumber)
        {
            List<ReservationData> reservations = new List<ReservationData>();

            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT
                                            PRH.RESERVATION_SERIAL_NUMBER,
                                            PRH.DESIRED_RESERVATION_DATE,
                                            PRH.DESIRED_RESERVATION_TIME,
                                            PRH.RESERVATION_SUCCESS_STATUS,
                                            PI.PATIENT_NAME,
                                            DI.DOCTOR_NAME,
                                            DI.DOCTOR_PRIMARY_DEPARTMENT
                                        FROM
                                            JUNG02.PATIENT_RESERVATION_HISTORY PRH
                                        JOIN
                                            JUNG02.PATIENT_INFO PI ON PRH.PATIENT_SERIAL_NUMBER = PI.PATIENT_SERIAL_NUMBER
                                        JOIN
                                            JUNG02.DOCTOR_INFO DI ON PRH.DOCTOR_SERIAL_NUMBER = DI.DOCTOR_SERIAL_NUMBER
                                        WHERE
                                            PI.PATIENT_SERIAL_NUMBER = :PatientSerialNumber";

                    command.Parameters.Add("PatientSerialNumber", OracleDbType.Decimal).Value = patientSerialNumber;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReservationData reservation = new ReservationData
                            {
                                ReservationSerialNumber = Convert.ToDecimal(reader["RESERVATION_SERIAL_NUMBER"]),
                                DesiredReservationDate = reader["DESIRED_RESERVATION_DATE"].ToString(),
                                DesiredReservationTime = reader["DESIRED_RESERVATION_TIME"].ToString(),
                                ReservationSuccessStatus = reader["RESERVATION_SUCCESS_STATUS"].ToString(),
                                PatientName = reader["PATIENT_NAME"].ToString(),
                                DoctorName = reader["DOCTOR_NAME"].ToString(),
                                DoctorPrimaryDepartment = reader["DOCTOR_PRIMARY_DEPARTMENT"].ToString()
                            };

                            reservations.Add(reservation);
                        }
                    }
                }
            }

            return reservations;

            //의사 즐겨찾기 기능 쿼리
        }
        public void select_favorites(decimal PationtPK, decimal DoctorPK)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(conn_info))
                {
                    connection.Open();

                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"
                    INSERT INTO JUNG02.PATIENT_FAVORITES 
                        (PATIENT_SERIAL_NUMBER, DOCTOR_SERIAL_NUMBER) 
                    VALUES 
                        (:PatientSerialNumber, :DoctorSerialNumber)";

                        command.Parameters.Add("PatientSerialNumber", OracleDbType.Decimal).Value = PationtPK;
                        command.Parameters.Add("DoctorSerialNumber", OracleDbType.Decimal).Value = DoctorPK;

                        command.ExecuteNonQuery();
                        Console.WriteLine("즐겨찾기 성공하셨습니다.");
                        MessageBox.Show("즐겨찾기 되셨습니다!");
                    }
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    Console.WriteLine("이미 즐겨찾기 되어있습니다.");
                    MessageBox.Show("이미 즐겨찾기 되어있습니다.");
                }
                else
                {
                    // 다른 오류에 대한 처리를 추가할 수 있습니다.
                    Console.WriteLine($"오류 발생: {ex.Number}, {ex.Message}");
                }
            }
        }

       //즐겨찾기한 의사들을 환자에게 뿌려주는 쿼리
        public List<FavoriteDoctorData> GetFavoriteDoctors(decimal patientSerialNumber)
        {
            List<FavoriteDoctorData> favoriteDoctors = new List<FavoriteDoctorData>();

            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT
                                            PF.PATIENT_SERIAL_NUMBER,
                                            PF.DOCTOR_SERIAL_NUMBER,
                                            DI.DOCTOR_NAME,
                                            DI.DOCTOR_EXPERIENCE,
                                            DI.DOCTOR_PHONE_NUMBER,
                                            DI.DOCTOR_EMAIL,
                                            DI.DOCTOR_PRIMARY_DEPARTMENT,
                                            DI.DOCTOR_INTRODUCTION,
                                            DI.DOCTOR_RECOMMENDATION_COUNT,
                                            DI.HOSPITAL_SERIAL_NUMBER
                                        FROM
                                            JUNG02.PATIENT_FAVORITES PF
                                        JOIN
                                            JUNG02.DOCTOR_INFO DI ON PF.DOCTOR_SERIAL_NUMBER = DI.DOCTOR_SERIAL_NUMBER
                                        WHERE
                                            PF.PATIENT_SERIAL_NUMBER = :PatientSerialNumber";

                    command.Parameters.Add("PatientSerialNumber", OracleDbType.Decimal).Value = patientSerialNumber;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FavoriteDoctorData favoriteDoctor = new FavoriteDoctorData
                            {
                                PatientSerialNumber = Convert.ToDecimal(reader["PATIENT_SERIAL_NUMBER"]),
                                DoctorSerialNumber = Convert.ToDecimal(reader["DOCTOR_SERIAL_NUMBER"]),
                                DoctorName = reader["DOCTOR_NAME"].ToString(),
                                DoctorExperience = reader["DOCTOR_EXPERIENCE"].ToString(),
                                DoctorPhoneNumber = reader["DOCTOR_PHONE_NUMBER"].ToString(),
                                DoctorEmail = reader["DOCTOR_EMAIL"].ToString(),
                                DoctorPrimaryDepartment = reader["DOCTOR_PRIMARY_DEPARTMENT"].ToString(),
                                DoctorIntroduction = reader["DOCTOR_INTRODUCTION"].ToString(),
                                DoctorRecommendationCount = Convert.ToDecimal(reader["DOCTOR_RECOMMENDATION_COUNT"]),
                                HospitalSerialNumber = Convert.ToDecimal(reader["HOSPITAL_SERIAL_NUMBER"])
                            };

                            favoriteDoctors.Add(favoriteDoctor);
                        }
                    }
                }
            }

            return favoriteDoctors;
        }
        public DoctorData GetDoctorInfo(decimal doctorSerialNumber)
        {
            DoctorData doctorData = null;

            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                                        SELECT
                                            DI.DOCTOR_SERIAL_NUMBER,
                                            DI.DOCTOR_NAME,
                                            DI.DOCTOR_EXPERIENCE,
                                            DI.DOCTOR_PHONE_NUMBER,
                                            DI.DOCTOR_EMAIL,
                                            DI.DOCTOR_PRIMARY_DEPARTMENT,
                                            DI.DOCTOR_INTRODUCTION,
                                            DI.DOCTOR_RECOMMENDATION_COUNT,
                                            DI.HOSPITAL_SERIAL_NUMBER,
                                            HI.HOSPITAL_NAME
                                        FROM
                                            JUNG02.DOCTOR_INFO DI
                                        JOIN
                                            JUNG02.HOSPITAL_INFO HI ON DI.HOSPITAL_SERIAL_NUMBER = HI.HOSPITAL_SERIAL_NUMBER
                                        WHERE
                                            DI.DOCTOR_SERIAL_NUMBER = :DoctorSerialNumber";

                    command.Parameters.Add("DoctorSerialNumber", OracleDbType.Decimal).Value = doctorSerialNumber;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            doctorData = new DoctorData
                            {
                                DoctorSerialNumber = Convert.ToDecimal(reader["DOCTOR_SERIAL_NUMBER"]),
                                DoctorName = reader["DOCTOR_NAME"].ToString(),
                                DoctorExp = reader["DOCTOR_EXPERIENCE"].ToString(),
                                DoctorPhoneNum = reader["DOCTOR_PHONE_NUMBER"].ToString(),
                                DoctorEmail = reader["DOCTOR_EMAIL"].ToString(),
                                DoctorDepartment = reader["DOCTOR_PRIMARY_DEPARTMENT"].ToString(),
                                DoctorIntroduce = reader["DOCTOR_INTRODUCTION"].ToString(),
                                DoctorRecoment = Convert.ToDecimal(reader["DOCTOR_RECOMMENDATION_COUNT"]),
                                DoctorHospital = reader["HOSPITAL_SERIAL_NUMBER"].ToString(),
                                HospitalName = reader.GetString(reader.GetOrdinal("HOSPITAL_NAME"))
                            };
                        }
                    }
                }
            }

            return doctorData;
        }

        //의사의 추천수를 업데이트 하는쿼리
        public void UP_COUNT(decimal doctorSerialNumber)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                // SQL 문 작성
                string sql = "UPDATE JUNG02.DOCTOR_INFO SET DOCTOR_RECOMMENDATION_COUNT = DOCTOR_RECOMMENDATION_COUNT + 1 WHERE DOCTOR_SERIAL_NUMBER = :DoctorSerialNumber";

                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    // 매개변수 추가
                    command.Parameters.Add("DoctorSerialNumber", OracleDbType.Decimal).Value = doctorSerialNumber;

                    // 쿼리 실행
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"추천 횟수가 증가되었습니다. 의사 번호: {doctorSerialNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"의사를 찾을 수 없습니다. 의사 번호: {doctorSerialNumber}");
                    }
                }
            }
        }
        public void Up_comment_num(decimal commentSerialNumber, decimal newRecommendationCount)
        {
            // 여기에 데이터베이스 업데이트 로직을 추가
            // 아래는 Oracle 데이터베이스를 사용한 예시이며, 사용하는 데이터베이스에 따라 방법이 달라질 수 있습니다.

            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                string updateQuery = "UPDATE COMMENTES SET COMMENT_RECOMMENDATION_COUNT = :NewRecommendationCount WHERE COMMENT_SERIAL_NUMBER = :CommentSerialNumber";

                using (OracleCommand command = new OracleCommand(updateQuery, connection))
                {
                    command.Parameters.Add(":NewRecommendationCount", OracleDbType.Decimal).Value = newRecommendationCount;
                    command.Parameters.Add(":CommentSerialNumber", OracleDbType.Decimal).Value = commentSerialNumber;

                    command.ExecuteNonQuery();
                }
            }
        }
        //즐겨찾기 해지
        public void delete_favorite(decimal PationtPK, decimal DoctorPK)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                DELETE FROM JUNG02.PATIENT_FAVORITES
                WHERE PATIENT_SERIAL_NUMBER = :PatientSerialNumber
                AND DOCTOR_SERIAL_NUMBER = :DoctorSerialNumber";

                    command.Parameters.Add("PatientSerialNumber", OracleDbType.Decimal).Value = PationtPK;
                    command.Parameters.Add("DoctorSerialNumber", OracleDbType.Decimal).Value = DoctorPK;

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("즐겨찾기 삭제 성공하셨습니다.");
                    }
                    else
                    {
                        Console.WriteLine("해당하는 즐겨찾기가 없습니다.");
                    }
                }
            }
        }
        
        //환자 측 에약 취소
        public void CancelReservation(decimal reservationSerialNumber)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                DELETE FROM JUNG02.PATIENT_RESERVATION_HISTORY
                WHERE RESERVATION_SERIAL_NUMBER = :ReservationSerialNumber";

                    command.Parameters.Add("ReservationSerialNumber", OracleDbType.Decimal).Value = reservationSerialNumber;

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("예약이 취소되었습니다.");
                    }
                    else
                    {
                        Console.WriteLine("해당하는 예약이 없습니다.");
                    }
                }
            }
        }
        public List<HospitalReservationData> GetReservationData(decimal hospitalSerialNumber)
        {
            List<HospitalReservationData> reservationList = new List<HospitalReservationData>();

            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                SELECT
                    P.PATIENT_NAME,
                    P.PATIENT_AGE,
                    D.DOCTOR_NAME,
                    R.DESIRED_RESERVATION_DATE,
                    R.DESIRED_RESERVATION_TIME,
                    R.RESERVATION_SERIAL_NUMBER, -- Added Reservation Serial Number
                    R.RESERVATION_SUCCESS_STATUS
                FROM
                    JUNG02.PATIENT_INFO P
                JOIN
                    JUNG02.PATIENT_RESERVATION_HISTORY R ON P.PATIENT_SERIAL_NUMBER = R.PATIENT_SERIAL_NUMBER
                JOIN
                    JUNG02.DOCTOR_INFO D ON R.DOCTOR_SERIAL_NUMBER = D.DOCTOR_SERIAL_NUMBER
                WHERE
                    D.HOSPITAL_SERIAL_NUMBER = :HospitalSerialNumber";

                    command.Parameters.Add("HospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HospitalReservationData reservation = new HospitalReservationData
                            {
                                PatientName = reader["PATIENT_NAME"].ToString(),
                                PatientAge = Convert.ToInt32(reader["PATIENT_AGE"]),
                                DoctorName = reader["DOCTOR_NAME"].ToString(),
                                DesiredDate = reader["DESIRED_RESERVATION_DATE"].ToString(),
                                DesiredTime = reader["DESIRED_RESERVATION_TIME"].ToString(),
                                RegisterSerialNumber = Convert.ToDecimal(reader["RESERVATION_SERIAL_NUMBER"]),
                                Reservation_Statment = reader["RESERVATION_SUCCESS_STATUS"].ToString()
                            };

                            reservationList.Add(reservation);
                        }
                    }
                }
            }

            return reservationList;
        }
        //병원 측 예약 수락
        public void AcceptReservation(int reservationSerialNumber)
        {
            // 예약 수락 로직을 수행합니다.
            // 데이터베이스 업데이트 쿼리를 실행합니다.
            // 아래는 예시로 Update 쿼리를 사용했습니다. 실제로는 해당 예약의 상태를 업데이트하는 쿼리를 작성해야 합니다.
            string updateQuery = "UPDATE JUNG02.PATIENT_RESERVATION_HISTORY SET RESERVATION_SUCCESS_STATUS = '예약 수락' WHERE RESERVATION_SERIAL_NUMBER = :ReservationSerialNumber";

            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(updateQuery, connection))
                {
                    command.Parameters.Add("ReservationSerialNumber", OracleDbType.Decimal).Value = reservationSerialNumber;

                    // 쿼리 실행
                    command.ExecuteNonQuery();
                }
            }
        }
        //병원 측 예약 거절
        public void CancelReservation(int reservationSerialNumber)
        {
            // 예약 취소 로직을 수행합니다.
            // 데이터베이스 업데이트 쿼리를 실행합니다.
            // 아래는 예시로 Update 쿼리를 사용했습니다. 실제로는 해당 예약의 상태를 업데이트하는 쿼리를 작성해야 합니다.
            string updateQuery = "UPDATE JUNG02.PATIENT_RESERVATION_HISTORY SET RESERVATION_SUCCESS_STATUS = '예약 불가' WHERE RESERVATION_SERIAL_NUMBER = :ReservationSerialNumber";

            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(updateQuery, connection))
                {
                    command.Parameters.Add("ReservationSerialNumber", OracleDbType.Decimal).Value = reservationSerialNumber;

                    // 쿼리 실행
                    command.ExecuteNonQuery();
                }
            }
        }//환자측 예약 확정
        public void ConfirmReservation(decimal reservationSerialNumber)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE JUNG02.PATIENT_RESERVATION_HISTORY SET RESERVATION_SUCCESS_STATUS = '예약 확정' WHERE RESERVATION_SERIAL_NUMBER = :ReservationSerialNumber";

                    command.Parameters.Add("ReservationSerialNumber", OracleDbType.Decimal).Value = reservationSerialNumber;

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<HospitalDoctorInfo> GetDoctorsForHospital(decimal hospitalSerialNumber)
        {
            List<HospitalDoctorInfo> hospital_doctors = new List<HospitalDoctorInfo>();

            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                    SELECT DOCTOR_NAME, DOCTOR_EXPERIENCE, DOCTOR_PRIMARY_DEPARTMENT, DOCTOR_RECOMMENDATION_COUNT, DOCTOR_SERIAL_NUMBER
                    FROM JUNG02.DOCTOR_INFO
                    WHERE HOSPITAL_SERIAL_NUMBER = :HospitalSerialNumber";

                    command.Parameters.Add("HospitalSerialNumber", OracleDbType.Decimal).Value = hospitalSerialNumber;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HospitalDoctorInfo doctor = new HospitalDoctorInfo
                            {
                                DoctorName = reader["DOCTOR_NAME"].ToString(),
                                DoctorExperience = reader["DOCTOR_EXPERIENCE"].ToString(),
                                DoctorPrimaryDepartment = reader["DOCTOR_PRIMARY_DEPARTMENT"].ToString(),
                                DoctorRecommendationCount = Convert.ToInt32(reader["DOCTOR_RECOMMENDATION_COUNT"]),
                                DoctorSerialNumber = Convert.ToDecimal(reader["DOCTOR_SERIAL_NUMBER"])
                            };

                            hospital_doctors.Add(doctor);
                        }
                    }
                }
            }

            return hospital_doctors;
        }
        public void RemoveDoctor(decimal doctorSerialNumber)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                connection.Open();

                using (OracleCommand command = connection.CreateCommand())
                {
                    // 의사 삭제 쿼리
                    command.CommandText = "DELETE FROM JUNG02.DOCTOR_INFO WHERE DOCTOR_SERIAL_NUMBER = :DoctorSerialNumber";
                    command.Parameters.Add("DoctorSerialNumber", OracleDbType.Decimal).Value = doctorSerialNumber;

                    // 쿼리 실행
                    command.ExecuteNonQuery();
                }
            }
        }
        //의사의 정보를 담아서 리스트에 담음
        public HospitalData GetHospitalData(decimal hospitalPK)
        {
            HospitalData hospitalData = new HospitalData();
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = @"
                                SELECT
                                    HI.HOSPITAL_SERIAL_NUMBER,
                                    HI.HOSPITAL_NAME,
                                    TO_CHAR(HI.HOSPITAL_PHONE_NUMBER) AS HOSPITAL_PHONE_NUMBER,
                                    HI.HOSPITAL_DOCTOR_COUNT,
                                    HI.HOSPITAL_SPECIAL_NOTES,
                                    HI.HOSPITAL_DIVISION,
                                    HI.HOSPITAL_MAP_IMAGE,
                                    HL.FIRST_LOCATION,
                                    HL.SECOND_LOCATION,
                                    HI.HOSPITAL_EMAIL,
                                    HL.DETAILED_LOCATION
                                FROM
                                    JUNG02.HOSPITAL_INFO HI
                                JOIN
                                    JUNG02.HOSPITAL_LOCATION HL ON HI.HOSPITAL_SERIAL_NUMBER = HL.HOSPITAL_SERIAL_NUMBER
                                WHERE
                                    HI.HOSPITAL_SERIAL_NUMBER = :HospitalPK";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add("HospitalPK", OracleDbType.Decimal).Value = hospitalPK;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                hospitalData.HospitalSerialNumber = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_SERIAL_NUMBER"));
                                hospitalData.HospitalName = reader.GetString(reader.GetOrdinal("HOSPITAL_NAME"));
                                hospitalData.HospitalPhoneNumber = reader.GetString(reader.GetOrdinal("HOSPITAL_PHONE_NUMBER"));
                                hospitalData.HospitalDoctorCount = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_DOCTOR_COUNT"));
                                hospitalData.HospitalSpecialNotes = reader.GetString(reader.GetOrdinal("HOSPITAL_SPECIAL_NOTES"));
                                hospitalData.HospitalDivision = reader.GetString(reader.GetOrdinal("HOSPITAL_DIVISION"));
                                hospitalData.HospitalEmail = reader.GetString(reader.GetOrdinal("HOSPITAL_EMAIL"));
                                //HospitalMapImage = (byte[])reader.GetValue(reader.GetOrdinal("HOSPITAL_MAP_IMAGE")),
                                hospitalData.FirstLocation = reader.GetString(reader.GetOrdinal("FIRST_LOCATION"));
                                hospitalData.SecondLocation = reader.GetString(reader.GetOrdinal("SECOND_LOCATION"));
                                hospitalData.DetailedLocation = reader.GetString(reader.GetOrdinal("DETAILED_LOCATION"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 쿼리 실행 중 오류: " + ex.Message);
                }
            }

            return hospitalData;
        }

        public List<DepartmentData> GetDepartments(decimal hospitalPK)
        {
            List<DepartmentData> departmentList = new List<DepartmentData>();

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = @"
                    SELECT
                        HD.HOSPITAL_SERIAL_NUMBER,
                        HD.DEPARTMENT_SERIAL_NUMBER,
                        D.DEPARTMENT_NAME,
                        D.DEPARTMENT_DESCRIPTION
                    FROM
                        JUNG02.HOSPITAL_DEPARTMENTS HD
                    JOIN
                        JUNG02.DEPARTMENT D ON HD.DEPARTMENT_SERIAL_NUMBER = D.DEPARTMENT_SERIAL_NUMBER
                    WHERE
                        HD.HOSPITAL_SERIAL_NUMBER = :HospitalPK";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add("HospitalPK", OracleDbType.Decimal).Value = hospitalPK;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DepartmentData departmentData = new DepartmentData
                                {
                                    HospitalSerialNumber = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_SERIAL_NUMBER")),
                                    DepartmentSerialNumber = reader.GetDecimal(reader.GetOrdinal("DEPARTMENT_SERIAL_NUMBER")),
                                    DepartmentName = reader.GetString(reader.GetOrdinal("DEPARTMENT_NAME")),
                                    DepartmentDescription = reader.GetString(reader.GetOrdinal("DEPARTMENT_DESCRIPTION"))
                                };

                                departmentList.Add(departmentData);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 쿼리 실행 중 오류: " + ex.Message);
                }
            }

            return departmentList;
        }
        public DepartmentData GetDepartmentInfo(decimal departmentSerialNumber)
        {
            DepartmentData departmentData = new DepartmentData(); // DepartmentData 클래스는 실제로 사용하는 데이터 클래스로 대체해야 합니다.

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = @"
                    SELECT
                        DEPARTMENT_SERIAL_NUMBER,
                        DEPARTMENT_NAME,
                        DEPARTMENT_DESCRIPTION
                    FROM
                        JUNG02.DEPARTMENT
                    WHERE
                        DEPARTMENT_SERIAL_NUMBER = :DepartmentSerialNumber";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add("DepartmentSerialNumber", OracleDbType.Decimal).Value = departmentSerialNumber;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                departmentData.DepartmentSerialNumber = reader.GetDecimal(reader.GetOrdinal("DEPARTMENT_SERIAL_NUMBER"));
                                departmentData.DepartmentName = reader.GetString(reader.GetOrdinal("DEPARTMENT_NAME"));
                                departmentData.DepartmentDescription = reader.GetString(reader.GetOrdinal("DEPARTMENT_DESCRIPTION"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 쿼리 실행 중 오류: " + ex.Message);
                }
            }

            return departmentData;
        }
        public List<BedData> GetHospitalBedInfo(decimal hospitalPK)
        {
            List<BedData> bedList = new List<BedData>();

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = @"
                SELECT
                    HB.HOSPITAL_SERIAL_NUMBER,
                    BD.BED_NAME,
                    BD.BED_DESCRIPTION,
                    HB.BED_QUANTITY,
                    HB.BED_SERIAL_NUMBER -- Newly added
                FROM
                    JUNG02.HOSPITAL_BEDS HB
                JOIN
                    JUNG02.BED BD ON HB.BED_SERIAL_NUMBER = BD.HOSPITAL_SERIAL_NUMBER
                WHERE
                    HB.HOSPITAL_SERIAL_NUMBER = :HospitalPK";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add("HospitalPK", OracleDbType.Decimal).Value = hospitalPK;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BedData bedData = new BedData
                                {
                                    HospitalSerialNumber = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_SERIAL_NUMBER")),
                                    BedName = reader.GetString(reader.GetOrdinal("BED_NAME")),
                                    BedDescription = reader.GetString(reader.GetOrdinal("BED_DESCRIPTION")),
                                    BedQuantity = reader.GetDecimal(reader.GetOrdinal("BED_QUANTITY")),
                                    SickBedSerialNumber = reader.GetDecimal(reader.GetOrdinal("BED_SERIAL_NUMBER")) // Newly added
                                };

                                bedList.Add(bedData);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed or error during query execution: " + ex.Message);
                }
            }

            return bedList;
        }
        public BedData GetSickBedInfo(decimal sickBedSerialNumber)
        {
            BedData sickBedData = null;

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = @"
                SELECT
                    HB.HOSPITAL_SERIAL_NUMBER,
                    BD.BED_NAME,
                    BD.BED_DESCRIPTION,
                    HB.BED_QUANTITY
                FROM
                    JUNG02.HOSPITAL_BEDS HB
                JOIN
                    JUNG02.BED BD ON HB.BED_SERIAL_NUMBER = BD.HOSPITAL_SERIAL_NUMBER
                WHERE
                    HB.BED_SERIAL_NUMBER = :SickBedSerialNumber";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add("SickBedSerialNumber", OracleDbType.Decimal).Value = sickBedSerialNumber;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                sickBedData = new BedData
                                {
                                    HospitalSerialNumber = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_SERIAL_NUMBER")),
                                    BedName = reader.GetString(reader.GetOrdinal("BED_NAME")),
                                    BedDescription = reader.GetString(reader.GetOrdinal("BED_DESCRIPTION")),
                                    BedQuantity = reader.GetDecimal(reader.GetOrdinal("BED_QUANTITY")),
                                    SickBedSerialNumber = sickBedSerialNumber
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed or error during query execution: " + ex.Message);
                }
            }

            return sickBedData;
        }
        public decimal GetHospitalPKByName(string hospitalName)
        {
            decimal hospitalPK = -1; // 기본값으로 -1을 설정하여 에러 상태를 나타낼 수 있습니다.

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                try
                {
                    conn.Open();

                    string sql = @"
                SELECT
                    HOSPITAL_SERIAL_NUMBER
                FROM
                    JUNG02.HOSPITAL_INFO
                WHERE
                    HOSPITAL_NAME = :HospitalName";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add("HospitalName", OracleDbType.Varchar2).Value = hospitalName;

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            hospitalPK = Convert.ToDecimal(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패 또는 쿼리 실행 중 오류: " + ex.Message);
                }
            }

            return hospitalPK;
        }

        public List<Department> GetAllDepartments()
        {
            List<Department> departmentList = new List<Department>();

            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                string query = "SELECT DEPARTMENT_NAME, DEPARTMENT_DESCRIPTION FROM JUNG02.DEPARTMENT";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        try
                        {
                            connection.Open();
                            adapter.Fill(dataTable);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                Department department = new Department
                                {
                                    DepartmentName = row["DEPARTMENT_NAME"].ToString(),
                                    DepartmentDescription = row["DEPARTMENT_DESCRIPTION"].ToString()
                                };
                                departmentList.Add(department);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }

            return departmentList;
        }
        public List<Bed> GetAllBeds()
        {
            List<Bed> bedList = new List<Bed>();

            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                string query = "SELECT BED_NAME, BED_DESCRIPTION FROM JUNG02.BED";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        try
                        {
                            connection.Open();
                            adapter.Fill(dataTable);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                Bed bed = new Bed
                                {
                                    BedName = row["BED_NAME"].ToString(),
                                    BedDescription = row["BED_DESCRIPTION"].ToString()
                                };
                                bedList.Add(bed);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }

            return bedList;
        }
    }
}

