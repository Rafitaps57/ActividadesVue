import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { EmprendedoresModule } from './emprendedores/emprendedores.module';
@Module({
  imports: [
    TypeOrmModule.forRoot({
      type: 'better-sqlite3',
      database: 'data.db',
      entities: [__dirname + '/**/*.entity{.ts,.js}'],
      synchronize: true,
    }),
    EmprendedoresModule,
  ],
  controllers: [],
  providers: [],
})
export class AppModule {}
