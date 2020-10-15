use
	MorseCodeDB
go

create procedure SaveTranslation
	@id int output,
	@text nvarchar(50), 
	@morse nvarchar(50)
as begin
    set @id = SCOPE_IDENTITY()

	insert into
		Translations
	values
		(@text, @morse, @id)
end
go