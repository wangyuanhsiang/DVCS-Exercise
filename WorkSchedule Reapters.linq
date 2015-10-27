<Query Kind="Expression">
  <Connection>
    <ID>7daef5af-d96b-42d6-8b39-a1f9de472020</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>


from E in EmployeeSkills 
select new
{
  ID = E.Employee.EmployeeID,
  Name = E.Employee.FirstName + " " +E.Employee.LastName,
  Contact = E.Employee.HomePhone,
  Skills = E.Skill.Description
}


//ID = Employee.EmployeeID,
//  Name = Employee.FirstName + " " + Employee.LastName,
//  Contact = Employee.HomePhone,
//  Skills = from S in Skills select S.Description