--select * from AspNetUsers
--inner join AspNetUserRoles on AspNetUsers.Id = AspNetUserRoles.UserId
--inner join AspNetRoles on AspNetUserRoles.RoleId = AspNetRoles.Id;

select * from Products
where Products.Customer_Id is not Null;