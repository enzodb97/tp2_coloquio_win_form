using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminEmpleadosEF.Migrations
{
    /// <inheritdoc />
    public partial class agregarempleado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                        INSERT INTO [dbo].[departamento]([dpto_nro],[Nombre])VALUES(10,'RRHH')
                        INSERT INTO [dbo].[departamento]([dpto_nro],[Nombre])VALUES(22,'SISTEMAS')
                        GO
                        INSERT INTO [dbo].[empleado]
                            ([Dni],[Nombre],[Direccion],[FechaIngreso],[Salario],[dpto_id])
                        VALUES
                            ('20123456','Emiliano Martinez','Calle 1','20000101',150000,1)
                        GO
                        INSERT INTO [dbo].[empleado]
                            ([Dni],[Nombre],[Direccion],[FechaIngreso],[Salario],[dpto_id])
                        VALUES
                            ('25222333','Lionel Messi','Miami','20050502',200000,2)
                        GO
                        INSERT INTO [dbo].[empleado] 
                            ([Dni],[Nombre],[Direccion],[FechaIngreso],[Salario],[dpto_id]) 
                        VALUES
                            ('33456789','Sergio Aguero','Buenos Aires','20060615',180000,1) 
                        GO
                        INSERT INTO [dbo].[empleado] ([Dni],[Nombre],[Direccion],[FechaIngreso],[Salario],[dpto_id])
                        VALUES 
                            ('45678901','Angel Di Maria','Rosario','20070707',175000,2) 
                        GO
                        INSERT INTO [dbo].[empleado] ([Dni],[Nombre],[Direccion],[FechaIngreso],[Salario],[dpto_id])
                        VALUES 
                            ('56789012','Paulo Dybala','Cordoba','20100523',160000,2)
                        GO
                        INSERT INTO [dbo].[empleado]
                            ([Dni],[Nombre],[Direccion],[FechaIngreso],[Salario],[dpto_id])
                            VALUES
                            ('67890123','Lautaro Martinez','Bahia','20180808',155000,1)
                        GO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" truncate table  empleado  ;
                                delete from departamento  ;
                                DBCC CHECKIDENT (departamento , RESEED, 0);    ");
        }
    }
}
