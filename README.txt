Packages : 

Microsoft.AspNetCore.Authentication.JwtBearer

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Design

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Tools

System.IdentityModel.Tokens.Jwt



(User Migration for Sample Data)

Apis : 

-------------------------------------------


Token: 

http://localhost:5213/api/user

(Post Method && email && password From Data)



-------------------------------------------


Productcategories : 

http://localhost:5213/api/ProductCategories/




-------------------------------------------


Products : 

http://localhost:5213/api/Products

For making new Products :

{
        
        "name": "Mobile Samsung A14",
        "ProductPrice": "20000",
        "ProductCategoryId": "03e59e58-ba5f-4074-a625-4bee423d7e29"
    }


-------------------------------------------

ProductReceipts : 

http://localhost:5213/api/ProductReceipts

For making new ProductReceipts : 
{
        
        "ProductNumber": "8",
        "ProductPrice": "20000",
        "TotalPrice": "160000",
        "ProductId":"2d78d6c8-88f4-41e9-a99d-bd9d25e5a3d4"
    }




-------------------------------------------

ProductTransfers: 

http://localhost:5213/api/ProductTransfers

For making new ProductTransfers: 
{
        
        "ProductNumber": "2",
        "ProductPrice": "20000",
        "TotalPrice": "40000",
        "ProductId":"2d78d6c8-88f4-41e9-a99d-bd9d25e5a3d4"
    }





-------------------------------------------

Report: 

http://localhost:5213/api/Report

(Post Method && sortType ? ="price")






