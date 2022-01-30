﻿namespace MedicalHub.DAL;

public class ThreadMessageAttachment
{

    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string DataUrl { get; set; }
    
    public ThreadMessage ThreadMessage { get; set; }
    
}

//
// Вложение к сообщению трэда (ThreadMessageAttachment)
// Id: uniqueidentifier;
// Name: nvarchar(512); // image1.png
// Data: varbinary(max); – если будем хранить бинарники в БД
// Path: nvarchar(max); – если храним на каком-то сторедже файлы (на серваке, например);
// ThreadMessageId: uniqueidentifier;