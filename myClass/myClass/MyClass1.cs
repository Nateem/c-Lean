using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClass
{
    public class MyClass1
    {
        public class Member
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime BirthDate { get; set; }
            public DateTime CreatedDate { get; set; }
            public int CreatedBy { get; set; }
            public DateTime UpdateDate { get; set; }
            public int UpdatedBy { get; set; }
            public bool IsDeleted { get; set; }

        }
        public List<Member> GetAllMemberInfo()
        {
            List<Member> result = new List<Member>()
            {
                new Member
                {
                    Id = 1,
                    Name = "Teem",
                    Email = "nateeteem@gmail.com",
                    BirthDate = new DateTime(1991,5,4),
                    CreatedDate = DateTime.Now,
                    CreatedBy = 1,
                    UpdateDate = DateTime.Now,
                    UpdatedBy = 1,
                    IsDeleted = false,
                },
                new Member
                {
                    Id = 2,
                    Name = "Teem2",
                    Email = "nateeteem2@gmail.com",
                    BirthDate = new DateTime(1991,5,4),
                    CreatedDate = DateTime.Now,
                    CreatedBy = 1,
                    UpdateDate = DateTime.Now,
                    UpdatedBy = 1,
                    IsDeleted = false,
                },
                new Member
                {
                    Id = 3,
                    Name = "Teem3",
                    Email = "nateeteem3@gmail.com",
                    BirthDate = new DateTime(1991,5,4),
                    CreatedDate = DateTime.Now,
                    CreatedBy = 1,
                    UpdateDate = DateTime.Now,
                    UpdatedBy = 1,
                    IsDeleted = false,
                },
                new Member
                {
                    Id = 4,
                    Name = "Teem4",
                    Email = "nateeteem4@gmail.com",
                    BirthDate = new DateTime(1991,5,4),
                    CreatedDate = DateTime.Now,
                    CreatedBy = 1,
                    UpdateDate = DateTime.Now,
                    UpdatedBy = 1,
                    IsDeleted = false,
                },
                new Member
                {
                    Id = 5,
                    Name = "Teem5",
                    Email = "nateeteem5@gmail.com",
                    BirthDate = new DateTime(1991,5,4),
                    CreatedDate = DateTime.Now,
                    CreatedBy = 1,
                    UpdateDate = DateTime.Now,
                    UpdatedBy = 1,
                    IsDeleted = false,
                }
               
            };
            Member o = new Member();
            o.Id = 6;
            o.Name = "Ttss";
            o.Email = "test@gmail.com";
            o.BirthDate = new DateTime(1992, 5, 4);
            o.CreatedDate = DateTime.Now;
            o.CreatedBy = 1;
            o.UpdateDate = DateTime.Now;
            o.UpdatedBy = 1;
            o.IsDeleted = false;

            result.Add(o);

            return result;

        }
    }
    
}
