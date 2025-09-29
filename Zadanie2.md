# Zadanie 2.

### a)

    SELECT DISTINCT
        e.* 
    FROM
        Employee AS e 
    INNER JOIN 
        Team AS t ON e.teamId = t.id
    INNER JOIN
        Vacation AS v ON e.id = v.employeeId 
    WHERE
        t.name = '.NET'  
         AND  YEAR(v.dateSince) = 2019;


### b) 
    SELECT
        e.id,
        e.name,
        ROUND(SUM(v.numberOfHours) / 8, 1) AS DniWykorzystane
    FROM
        Employee AS e
    INNER JOIN
        VacationPackage AS vp ON e.vacationPackageId = vp.id
    INNER JOIN
        Vacation AS v ON e.id = v.employeeId
    WHERE
        YEAR(v.dateSince) = YEAR(CURRENT_DATE())
        AND v.dateUntil < CURRENT_DATE()
    GROUP BY
        e.id, e.name, vp.name

### c)

    SELECT
        t.id AS TeamId,
        t.name AS TeamName
    FROM
        Team AS t
    WHERE
        t.id NOT IN (
            SELECT DISTINCT
                e.teamId
            FROM
                Employee AS e
            INNER JOIN
                Vacation AS v ON e.id = v.employeeId
            WHERE
                YEAR(v.dateSince) = 2019
        );