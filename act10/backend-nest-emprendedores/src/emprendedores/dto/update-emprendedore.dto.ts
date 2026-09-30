import { PartialType } from '@nestjs/swagger';
import { CreateEmprendedorDto } from './create-emprendedore.dto';

export class UpdateEmprendedorDto extends PartialType(CreateEmprendedorDto) {}