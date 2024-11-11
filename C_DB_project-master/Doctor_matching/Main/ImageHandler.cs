using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.IO;

namespace Main
{
    class ImageHandler
    {
        private string conn_info;
        public ImageHandler()
        {
            conn_info = "User Id=jung02; Password=1234; Data Source=(DESCRIPTION = " +
                             "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) " +
                             "(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
        }

        //환자 이미지 저장함수
        public void SaveImage(decimal patientSerialNumber, byte[] imageBytes)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(conn_info))
                {
                    conn.Open();

                    string sql = "INSERT INTO JUNG02.PATIENT_IMAGE (PATIENT_SERIAL_NUMBER, PATIENT_IMAGE) VALUES (:patientSerialNumber, :patientImage)";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(":patientSerialNumber", OracleDbType.Decimal).Value = patientSerialNumber;
                        cmd.Parameters.Add(":patientImage", OracleDbType.Blob).Value = imageBytes;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        Console.WriteLine($"이미지가 데이터베이스에 저장되었습니다. 영향 받은 행 수: {rowsAffected}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("이미지 저장 중 오류 발생: " + ex.Message);
            }
        }
        //이미지를 가져오는 함수
        public byte[] RetrieveImage(decimal patientSerialNumber)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(conn_info))
                {
                    conn.Open();

                    string sql = "SELECT PATIENT_IMAGE FROM JUNG02.PATIENT_IMAGE WHERE PATIENT_SERIAL_NUMBER = :patientSerialNumber";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(":patientSerialNumber", OracleDbType.Decimal).Value = patientSerialNumber;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return (byte[])reader["PATIENT_IMAGE"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("이미지 불러오기 중 오류 발생: " + ex.Message);
            }

            return null;
        }
        
        //이미지 업데이트함수
        public void UpdateImage(decimal patientSerialNumber, byte[] newImageBytes)
        {

            try
            {
                using (OracleConnection conn = new OracleConnection(conn_info))
                {
                    conn.Open();

                    string sql = "UPDATE JUNG02.PATIENT_IMAGE SET PATIENT_IMAGE = :newImage WHERE PATIENT_SERIAL_NUMBER = :patientSerialNumber";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(":newImage", OracleDbType.Blob).Value = newImageBytes;
                        cmd.Parameters.Add(":patientSerialNumber", OracleDbType.Decimal).Value = patientSerialNumber;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        Console.WriteLine($"이미지가 업데이트되었습니다. 영향 받은 행 수: {rowsAffected}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("이미지 업데이트 중 오류 발생: " + ex.Message);
            }
        }
    }
}
