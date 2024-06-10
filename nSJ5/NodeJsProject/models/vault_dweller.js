const db = require ('../config/config');

const VaultDweller = {};

VaultDweller.create = (vault_dweller, result) => {
    const sql = `
            INSERT INTO
                vault_dweller(
                    name,
                    gender,
                    life,
                    level,
                    strength,
                    perception,
                    endurance,
                    charisma,
                    inteligence,
                    agility,
                    luck
                )
            VALUES (?,?,?,?,?,?,?,?,?,?,?)       
    `;

    db.query(
        sql, [
            vault_dweller.name,
            vault_dweller.gender,
            vault_dweller.life,
            vault_dweller.level,
            vault_dweller.strength,
            vault_dweller.perception,
            vault_dweller.endurance,
            vault_dweller.charisma,
            vault_dweller.inteligence,
            vault_dweller.agility,
            vault_dweller.luck
        ], (err, res) => {
            if (err){
                console.log ("Error al crear al morador:", err);
                result(err, null);
            } else {
                console.log ('Id del nuevo morador', res.insertId);
                result(null, res.insertId);
            }
        }
    )
}

VaultDweller.getDweller = (vault_dweller, result) => {
    const sql = `
    SELECT * FROM vault_dweller
    WHERE id = ?
    `;
    
    db.query(
        sql, [vault_dweller.id], (err, res) => {
            if (err) {
                console.log ("error en la busqueda: ", err);
                result(err, null);
            }
            else
            {
                result (null, res);
                console.log ('nombre del morador', res.id);
            }
        }
    )
}

VaultDweller.getAllDwellers = (vault_dweller, result) => {
    const sql = `
    SELECT * FROM vault_dweller
    WHERE id
    `;
    
    db.query(
        sql, [vault_dweller.id], (err, res) => {
            if (err) {
                console.log ("error en la busqueda: ", err);
                result(err, null);
            }
            else
            {
                result (null, res);
                console.log ('Lista completa', res.id);
            }
        }
    )
}

VaultDweller.updateDatos = (datos, result) => {
    const sql = `
    INSERT INTO 
    datos(
            energia,
            agua,
            comida
    ) 
       VALUES (?,?,?)
    `;

    db.query(
        sql, [
            datos.energia,
            datos.agua,
            datos.comida,
        ], (err, res) => {
            if (err){
                console.log ("Error al cargar los datos:", err);
                result(err, null);
            } else {
                console.log ('La info si se actualizo ', res);
                result(null, res);
            }
        }
    )
}

VaultDweller.setDatos = (datos,result) => {
    const sql = `
    
    Set
    (
     energia, 
     agua,
     comida
    )
     
     Where id = 1
     `

     db.query(
        sql, [
            datos.energia,
            datos.agua,
            datos.comida,
        ], (err,res) => {
            if(err){
                console.log("Error al cambiar los datos:",err);
                result(err,null);
            }else{
                console.log('La info si se cambio')
                result(null,res);
            }
        }

     )
    ;
    
}

module.exports = VaultDweller;