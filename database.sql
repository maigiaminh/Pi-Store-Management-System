CREATE DATABASE PiStoreDB

USE PiStoreDB

-- Tạo Bảng Employee gồm ID, Name, Email, Password, Phone, Salary, HireDate
CREATE TABLE Employee (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
	Password NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL UNIQUE,
    Address NVARCHAR(200) NOT NULL,
    Salary DECIMAL(18, 2) NOT NULL,
    HireDate DATE NOT NULL,
);

-- Tạo Bảng Client gồm ID, Name, Email, Phone, Address
CREATE TABLE Client (
    ID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE,
    Phone NVARCHAR(20) UNIQUE,
    Address NVARCHAR(255)
);

-- Tạo Bảng Product gồm ID, Name, Description, Price, Quantity
CREATE TABLE Product (
    ID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Description NVARCHAR(255),
    Price DECIMAL(10,2),
    Quantity INT
);

-- Tạo Bảng Order gồm ID, ClientID, EmployeeID, OrderDate, TotalPrice
CREATE TABLE [Order] (
    ID INT PRIMARY KEY IDENTITY,
    ClientID INT FOREIGN KEY REFERENCES Client(ID),
    EmployeeID INT FOREIGN KEY REFERENCES Employee(ID),
    OrderDate DATE,
    TotalPrice DECIMAL(10,2)
);

-- Tạo Bảng OrderItem gồm ID, OrderID, ProductID, Quantity
CREATE TABLE OrderItem (
    ID INT PRIMARY KEY IDENTITY,
    OrderID INT FOREIGN KEY REFERENCES [Order](ID),
    ProductID INT FOREIGN KEY REFERENCES Product(ID),
    Quantity INT
);

-- Tạo Bảng Bill gồm ID, OrderID, ClientID, EmployeeID, BillDate, TotalPrice
CREATE TABLE Bill (
    ID INT PRIMARY KEY IDENTITY,
    OrderID INT FOREIGN KEY REFERENCES [Order](ID),
    ClientID INT FOREIGN KEY REFERENCES Client(ID),
    EmployeeID INT FOREIGN KEY REFERENCES Employee(ID),
    BillDate DATE,
    TotalPrice DECIMAL(10,2)
);

-- Thêm các dữ liệu vào bảng Employee
INSERT INTO Employee (Name, Email, Password, Phone, Address, Salary, HireDate) VALUES
('Mai Gia Minh', 'minh.mgia@gmail.com', 'Minh1234', '0903614342', N'Quận Gò Vấp, TP.HCM', 20000000, '2024-09-17'),
(N'Nguyễn Phương Tài', 'tainguyen@gmail.com', 'Tai123456789', '0375830891', N'Quận 5, TP.HCM', 20000000, '2024-09-20'),
(N'Bùi Anh Minh', 'anhminh@gmail.com', 'Mint199727', '0337199727', N'Quận 7, TP.HCM', 20000000, '2024-09-20')

INSERT INTO Client (Name, Email, Phone, Address)
VALUES 
(N'Nguyễn Văn An', 'nguyenvanan@example.com', '0912345678', N'Quận 1, TP.HCM'),
(N'Trần Thị Liên', 'tranthilien@example.com', '0987654321', N'Quận 2, TP.HCM'),
(N'Phạm Hồng Hạnh', 'phamhonghanh@example.com', '0909090909', N'Quận 3, TP.HCM'),
(N'Lê Hoàng Nhất', 'lehoangnhat@example.com', '0979797979', N'Quận 4, TP.HCM'),
(N'Võ Minh Duy', 'vominhduy@example.com', '0888888888', N'Quận 5, TP.HCM'),
(N'Nguyễn An Khang', 'nguyenankhang@example.com', '0911111111', N'12 Đường Khang, Quận 6, TP.HCM'),
(N'Lê Hữu Lộc', 'lehuuloc@example.com', '0922222222', N'34 Đường Lộc, Quận 7, TP.HCM'),
(N'Phạm Nhật Nam', 'phamnhatnam@example.com', '0933333333', N'56 Đường Nam, Quận 8, TP.HCM'),
(N'Trần Thanh Tùng', 'tranthanhtung@example.com', '0944444444', N'78 Đường Tùng, Quận 9, TP.HCM'),
(N'Hoàng Minh Triết', 'hoangminhtriet@example.com', '0955555555', N'90 Đường Triết, Quận 10, TP.HCM');

INSERT INTO Product (Name, Description, Price, Quantity)
VALUES 
(N'Nike Air Force 1', N'Giày sneaker màu trắng', 2500000, 100),
(N'Adidas UltraBoost', N'Giày sneaker thể thao', 3000000, 50),
(N'Converse Chuck Taylor', N'Giày sneaker cổ cao', 1800000, 80),
(N'Puma Suede Classic', N'Giày sneaker màu đen', 2200000, 120),
(N'Vans Old Skool', N'Giày sneaker phong cách retro', 1700000, 90);

INSERT INTO [Order] (ClientID, EmployeeID, OrderDate, TotalPrice)
VALUES 
(1, 1, '2024-11-15', 4500000),
(2, 1, '2024-10-16', 3000000),
(3, 1, '2024-10-17', 2500000),
(4, 2, '2024-10-18', 5000000),
(5, 3, '2024-10-19', 4200000);

INSERT INTO OrderItem (OrderID, ProductID, Quantity)
VALUES 
(6, 1, 1),
(6, 3, 1),
(7, 2, 1),
(8, 1, 1),
(9, 4, 2),
(10, 5, 2); 

INSERT INTO Bill (OrderID, ClientID, EmployeeID, BillDate, TotalPrice)
VALUES 
(6, 1, 1, '2024-11-15', 4500000),
(7, 2, 1, '2024-10-16', 3000000),
(8, 3, 1, '2024-10-17', 2500000),
(9, 4, 2, '2024-10-18', 5000000),
(10, 5, 3, '2024-10-19', 4200000);

