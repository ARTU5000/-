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

VaultDweller.update = (vault_dweller, result) => {
    const sql = `
        UPDATE vault_dweller
        SET
            name = ?,
            gender = ?,
            life = ?,
            level = ?,
            strength = ?,
            perception = ?,
            endurance = ?,
            charisma = ?,
            inteligence = ?,
            agility = ?,
            luck = ?
        WHERE id = ?
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
            vault_dweller.luck,
            vault_dweller.id
        ], (err, res) => {
            if (err) {
                console.log("Error al actualizar al morador:", err);
                result(err, null);
            } else if (res.affectedRows == 0) {
                console.log("No se encontró el morador con id:", vault_dweller.id);
                result({ kind: "not_found" }, null);
            } else {
                console.log("Morador actualizado:", { id: vault_dweller.id, ...vault_dweller });
                result(null, { id: vault_dweller.id, ...vault_dweller });
            }
        }
    );
}

module.exports = VaultDweller;