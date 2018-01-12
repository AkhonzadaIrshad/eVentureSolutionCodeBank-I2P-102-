		--Queries Related to Products--

--Select All Products
select * from [ComplainMgt].[dbo].[Products]

--Select All Product Categories
select * from [ComplainMgt].[dbo].[ProductCategories]

--Select a Product By Id
select * from [ComplainMgt].[dbo].[Products]  
		 where [Products].[Id]=@Product_Id;

--Select All Products By Category Id
select * from [ComplainMgt].[dbo].[Products]  
		 where [Products].[Category_Id]=@Product_Category_Id;



		--Queries Related to Complaints
	
--Select All Complaints
select * from [ComplainMgt].[dbo].[Complaints]


--Select a Complaints By Id
select * from [ComplainMgt].[dbo].[Complaints]
		 where [Complaints].[Id]=@Complaint_Id

--Select All Complaints By Product Id
select * from [ComplainMgt].[dbo].[Complaints]
		 where [Complaints].[Product_Id]=@Product_Id

--Select All Complaints By Customer Id
select * from [ComplainMgt].[dbo].[Complaints]
		 where [Complaints].[Customer_Id]=@Customer_Id

--Select All Complaints By Complaints Status Id
select * from [ComplainMgt].[dbo].[Complaints]
		 where [Complaints].[ComplaintStatus_Id]=@Complaints_Status_Id


--Select All Complaints By Complaints Priority Id
select * from [ComplainMgt].[dbo].[Complaints]
		 where [Complaints].[ComplaintPriority_Id]=@Complaints_Priority_Id


--Select a Complaints By Token Number
select * from [ComplainMgt].[dbo].[Complaints]
		 where [Complaints].[TokenNumber]=@TokenNumber

--Select All Complaints Assigned to a TSP
select * from [ComplainMgt].[dbo].[Complaints]
		 where [Product_Id]=
				(select [Product_Id] from [ComplainMgt].[dbo].[Products]
									 where [Category_Id]=
											(select * from [ComplainMgt].[dbo].[TSPs]
													  where [Id]=@TSPs_Id
											)
				)



		--Queries Related to Responses

--Select All Responses
select * from [ComplainMgt].[dbo].[Responses]

--Select a Responses By Id
select * from [ComplainMgt].[dbo].[Responses]
		 where [Id]=@Response_Id

--select All Responses By Complaint Id
select * from [ComplainMgt].[dbo].[Responses]
		 where [Complaint_Id]=@Complaint_Id
 
 --select All Responses By Response Id
select * from [ComplainMgt].[dbo].[Responses]
		 where [TSP_Id]=@TSP_Id

--select All Responses By Response Id
select * from [ComplainMgt].[dbo].[Responses]
		 where [ResponseType_Id]=@ResponseType_Id

 

		--Queries Related to TSPs

--Select All TSPs
select * from [ComplainMgt].[dbo].[TSPs]

--Select TSP By LoginId and Password
select * from [ComplainMgt].[dbo].[TSPs]
		 where [LoginId]=@Login_Id AND
			   [Password]=@Password

--Select All TSPs By Product Category Id
select * from [ComplainMgt].[dbo].[TSPs]
	     where [ProductCategory_Id]=@Product_Category_Id






 		--Queries Related to TSPs

--Select All Customers
select * from [ComplainMgt].[dbo].[Customers]