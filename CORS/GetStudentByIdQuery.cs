namespace CORS
{
    public class GetStudentByIdQuery // getbyıd işleminin gerçekleşeceği yer 
    {
        public int Id  { get; set; }

        public GetStudentByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
