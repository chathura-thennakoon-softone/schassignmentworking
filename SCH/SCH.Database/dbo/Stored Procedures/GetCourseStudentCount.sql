CREATE PROCEDURE [dbo].[GetCourseStudentCount]
AS
BEGIN
    SET NOCOUNT ON;

    /*
        16. IQ Issue | Missing | Low

    SELECT
        c.Id,
        c.Name,
        COUNT(scm.StudentId) AS StudentCount
    FROM dbo.Course c
    LEFT JOIN dbo.StudentCourseMap scm ON c.Id = scm.CourseId
    GROUP BY c.Id, c.Name
    ORDER BY c.Name;

    */
    SELECT
        0 AS Id,
        'Test' AS Name,
        0 AS StudentCount

END
