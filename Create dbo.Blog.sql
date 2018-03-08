
CREATE TABLE [dbo].[Blog] (
    [BlogId]     INT            IDENTITY (1, 1) NOT NULL,
    [Url]        NVARCHAR (MAX) NOT NULL,
    [BlogName]   NVARCHAR (500) NULL,
    [CreateDate] DATETIME       NULL,
    [Owner]      NVARCHAR (250) NULL
);


CREATE TABLE [dbo].[Post] (
    [PostId]     INT            IDENTITY (1, 1) NOT NULL,
    [BlogId]     INT            NOT NULL,
    [Content]    NVARCHAR (MAX) NULL,
    [Title]      NVARCHAR (MAX) NULL,
    [CreateDate] DATETIME       NULL,
    [LastUpdate] DATETIME       NULL
);


SET IDENTITY_INSERT [dbo].[Blog] ON
INSERT INTO [dbo].[Blog] ([BlogId], [Url], [BlogName], [CreateDate], [Owner]) VALUES (1, N'http://blogs.msdn.com/dotnet', N'DOTNET', N'2018-03-06 21:30:39', NULL)
INSERT INTO [dbo].[Blog] ([BlogId], [Url], [BlogName], [CreateDate], [Owner]) VALUES (2, N'http://blogs.msdn.com/webdev', N'Web Development', N'2018-03-07 06:24:55', NULL)
INSERT INTO [dbo].[Blog] ([BlogId], [Url], [BlogName], [CreateDate], [Owner]) VALUES (3, N'http://blogs.msdn.com/visualstudio', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Blog] OFF