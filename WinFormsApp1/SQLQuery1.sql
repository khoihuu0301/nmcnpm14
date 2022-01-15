--Xep hang top 10

create or alter proc top10student
as
begin
	select top 10 ID_HS, Ten_HS from HOCSINH order by TotalPoint desc
end
go
--Danh sach bai tap da lam cua 1 hs
create or alter proc myExercises @ID int
as
begin
	select bt.ID_BT, bt.DeBai, hb.score from HS_BT hb join BAITAP bt on hb.ID_BT = bt.ID_BT
	where hb.ID_HS = @ID
end
go

--