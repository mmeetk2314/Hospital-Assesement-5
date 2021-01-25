SET IDENTITY_INSERT [dbo].[Hospital] ON
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [HospitalOpeningDate], [HospitalAddress], [HospitalFloor]) VALUES (1, N'Guru', N'Amritsar', N'2021-01-30 19:14:00', N'Amritsar', 2)
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [HospitalOpeningDate], [HospitalAddress], [HospitalFloor]) VALUES (2, N'Singha', N'Jalandhar', N'2020-12-12 19:15:00', N'Jalandhar', 3)
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [HospitalOpeningDate], [HospitalAddress], [HospitalFloor]) VALUES (3, N'Aman', N'Rayya', N'2020-12-30 19:15:00', N'Rayya', 2)
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [HospitalOpeningDate], [HospitalAddress], [HospitalFloor]) VALUES (4, N'Daman', N'Amritsar', N'2021-01-07 19:15:00', N'Amritsar', 3)
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [HospitalOpeningDate], [HospitalAddress], [HospitalFloor]) VALUES (5, N'Ryan', N'Chandigarh', N'2021-01-06 19:16:00', N'Chandigarh', 3)
SET IDENTITY_INSERT [dbo].[Hospital] OFF
SET IDENTITY_INSERT [dbo].[Doctor] ON
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [StartDate], [ContactNumber], [EmailId], [HospitalID]) VALUES (1, N'Arsh', N'2021-01-15 19:19:00', 22345677, N'Arsh@gmail.com', 1)
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [StartDate], [ContactNumber], [EmailId], [HospitalID]) VALUES (2, N'Geeta', N'2021-01-14 19:19:00', 226678789, N'Geeta@gmail.com', 2)
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [StartDate], [ContactNumber], [EmailId], [HospitalID]) VALUES (3, N'Daram', N'2021-01-01 19:20:00', 225667788, N'Daram@gmail.com', 3)
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [StartDate], [ContactNumber], [EmailId], [HospitalID]) VALUES (4, N'Mishra', N'2020-12-11 19:20:00', 22667889, N'Mishra@gmail.com', 4)
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [StartDate], [ContactNumber], [EmailId], [HospitalID]) VALUES (5, N'Pooja', N'2021-01-02 19:21:00', 22687999, N'Pooja@gmail.com', 5)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [PatientAddress], [DoctorID]) VALUES (1, N'Arushi', 22678899, N'Amritsar', 1)
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [PatientAddress], [DoctorID]) VALUES (2, N'Durga', 223677878, N'Jalandhar', 2)
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [PatientAddress], [DoctorID]) VALUES (3, N'Pankaj', 22567687, N'Haryana', 3)
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [PatientAddress], [DoctorID]) VALUES (4, N'Ekta', 2265789, N'Jalandhar', 4)
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [PatientAddress], [DoctorID]) VALUES (5, N'Jass', 2276878, N'Amritsar', 5)
SET IDENTITY_INSERT [dbo].[Patient] OFF
SET IDENTITY_INSERT [dbo].[Medicine] ON
INSERT INTO [dbo].[Medicine] ([MedicineID], [MedicineName], [Price], [HospitalID]) VALUES (1, N'Paracetamol', 240, 1)
INSERT INTO [dbo].[Medicine] ([MedicineID], [MedicineName], [Price], [HospitalID]) VALUES (2, N'Panadol', 190, 2)
INSERT INTO [dbo].[Medicine] ([MedicineID], [MedicineName], [Price], [HospitalID]) VALUES (3, N'Paracetamol', 230, 3)
INSERT INTO [dbo].[Medicine] ([MedicineID], [MedicineName], [Price], [HospitalID]) VALUES (4, N'Panadol', 180, 4)
INSERT INTO [dbo].[Medicine] ([MedicineID], [MedicineName], [Price], [HospitalID]) VALUES (5, N'Paracetamol', 250, 5)
SET IDENTITY_INSERT [dbo].[Medicine] OFF
