# TINGY-Restaurant-Management-System
## Hướng dẫn sử dụng
1. Cài đặt các phần mềm cần thiết:
* Visual Studio
* SQL Server 2022 và SSMS
2. Tải source code về máy
3. Tạo database:
* Trong thư mục vừa giải nén, tìm file tingyshop.sql, nhấn chuột phải và chọn Open with SSMS
* Cửa sổ SSMS xuất hiện, copy tên **Server name** của bạn và ấn nút 'Connect'
![image](https://user-images.githubusercontent.com/28885151/235122740-50326479-0650-4bf1-9aba-9b786c711a10.png)
* Trong thư mục vừa giải nén, tìm file SQLControl.cs và mở lên, thay thế dòng 'localhost' thành tên server vừa lưu
![image](https://user-images.githubusercontent.com/28885151/235123067-cf6c2dea-56d8-4868-9ce6-bd820b3affdd.png)
* Quay trở lại file tingyshop.sql trong SMSS, bôi đen dòng đầu tiên và nhấn (hoặc bấm nút 'Execute')
![image](https://user-images.githubusercontent.com/28885151/235121345-69617d39-dd2c-4386-a0e3-c6c31adfdbb3.png)
* Phía trên bên trái, chuyển từ master sang **tingyshop**
![image](https://user-images.githubusercontent.com/28885151/235121849-ce82934f-81fd-443a-89a7-a0a39df39c8b.png)
* Bôi **TẤT CẢ** những script còn lại và nhấn F5 (hoặc bấm nút 'Execute')
![image](https://user-images.githubusercontent.com/28885151/235122054-b37fb1e3-a3dd-4c34-a49f-61e3e01ee597.png)
* Trong thư mục vừa giải nén, mở file RMS_TINGY.sln
* Nhấn Ctrl + F5 để chạy chương trình
`Tài khoản admin:
Username: admin
Password: admin`
` Tài khoản staff:
Username: staff
Password: staff`


