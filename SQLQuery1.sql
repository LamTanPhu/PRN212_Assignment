Use master
Create Database prn212_assignment
Use prn212_assignment

CREATE TABLE Books (
    BookID INT PRIMARY KEY,
    Title VARCHAR(255),
    Author VARCHAR(255),
    Genre VARCHAR(255),
    PublicationYear INT,
    Status VARCHAR(255)
);

CREATE TABLE Members (
    MemberID INT PRIMARY KEY,
    Name VARCHAR(255),
    ContactInformation VARCHAR(255)
);

CREATE TABLE Borrowing (
    BorrowID INT PRIMARY KEY,
    BookID INT,
    MemberID INT,
    BorrowDate DATE,
    ReturnDate DATE,
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);

CREATE TABLE Reservation (
    ReservationID INT PRIMARY KEY,
    BookID INT,
    MemberID INT,
    ReservationDate DATE,
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);

CREATE TABLE Staff (
    StaffID INT PRIMARY KEY,
    Name VARCHAR(255),
    Username VARCHAR(255),
    PasswordHash VARCHAR(255), -- Store hashed password, not plain text
    Role VARCHAR(255) -- e.g., 'Librarian', 'Manager'
);
Drop table Staff
Select * From Staff


-- Inserting data into the Books table
INSERT INTO Books (BookID, Title, Author, Genre, PublicationYear, Status)
VALUES (1, 'To Kill a Mockingbird', 'Harper Lee', 'Fiction', 1960, 'Available'),
       (2, '1984', 'George Orwell', 'Dystopian', 1949, 'Checked Out'),
       (3, 'The Great Gatsby', 'F. Scott Fitzgerald', 'Fiction', 1925, 'Available');

-- Inserting data into the Members table
INSERT INTO Members (MemberID, Name, ContactInformation)
VALUES (1, 'John Doe', 'johndoe@example.com'),
       (2, 'Jane Smith', 'janesmith@example.com');

-- Inserting data into the Borrowing table
INSERT INTO Borrowing (BorrowID, BookID, MemberID, BorrowDate, ReturnDate)
VALUES (1, 2, 1, '2024-06-01', NULL); -- NULL indicates the book hasn't been returned yet

-- Inserting data into the Reservation table
INSERT INTO Reservation (ReservationID, BookID, MemberID, ReservationDate)
VALUES (1, 2, 2, '2024-06-15'); -- Member 2 has reserved the book currently borrowed by Member 1
