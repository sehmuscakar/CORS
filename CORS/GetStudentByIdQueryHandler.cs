using CORS.Data;

namespace CORS
{
    public class GetStudentByIdQueryHandler // işlemlerimizi burda gerçekleştirecez
    {
        private readonly StudentContext _context;

        public GetStudentByIdQueryHandler(StudentContext context)
        {
            _context = context;
        }

        public GetStudentByIdQueryResult Handle(GetStudentByIdQuery query)
        {
            var student = _context.Set<Student>().Find(query.Id);
            return new GetStudentByIdQueryResult
            {
                Age=student.Age,
                Name=student.Name,
                Surname=student.Surname,
            };
        }


    }
}
