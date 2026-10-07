local bit = bit32 or bit
Mut0 = function(l0) return { __tag = "Mut0", l0 = l0 } end

Mut1 = function(l0, l1, l2) return { __tag = "Mut1", l0 = l0, l1 = l1, l2 = l2 } end

Mut2 = function(l0) return { __tag = "Mut2", l0 = l0 } end

Mut3 = function(l0) return { __tag = "Mut3", l0 = l0 } end

function method0(v0)
    local v1 = v0 ~= nil and v0.l0
    local v2 = v1 < 7040
    return v2          
end

function method1(v0)
    local v1 = v0 ~= nil and v0.l0
    local v2 = v1 < 60
    return v2          
end

function method4(v0, v1)
    local v2 = v1 ~= nil and v1.l0
    local v3 = v2 < v0
    return v3          
end

function method5(v0, v1)
    local v2 = v1 ~= nil and v1.l0
    local v3 = v2 < v0
    return v3          
end

function method6(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9)
    local v10 = math.sin(v2)
    local v11 = v7 * v10
    local v12 = math.sin(v3)
    local v13 = v11 * v12
    local v14 = math.cos(v4)
    local v15 = v13 * v14
    local v16 = math.cos(v2)
    local v17 = v8 * v16
    local v18 = v17 * v12
    local v19 = v18 * v14
    local v20 = v15 - v19
    local v21 = v7 * v16
    local v22 = math.sin(v4)
    local v23 = v21 * v22
    local v24 = v20 + v23
    local v25 = v8 * v10
    local v26 = v25 * v22
    local v27 = v24 + v26
    local v28 = math.cos(v3)
    local v29 = v6 * v28
    local v30 = v29 * v14
    local v31 = v27 + v30
    local v32 = v21 * v14
    local v33 = v25 * v14
    local v34 = v32 + v33
    local v35 = v13 * v22
    local v36 = v34 - v35
    local v37 = v18 * v22
    local v38 = v36 + v37
    local v39 = v29 * v22
    local v40 = v38 - v39
    local v41 = v17 * v28
    local v42 = v11 * v28
    local v43 = v41 - v42
    local v44 = v6 * v12
    local v45 = v43 + v44
    local v46 = v45 + 100.0
    local v47 = 1.0 / v46
    local v48 = 80.0 + v5
    local v49 = 40.0 * v47
    local v50 = v49 * v31
    local v51 = v50 * 2.0
    local v52 = v48 + v51
    local v53 = v52
    local v54 = v49 * v40
    local v55 = 22.0 + v54
    local v56 = v55
    local v57 = v56 * 160
    local v58 = v53 + v57
    local v59 = v58 >= 0
    local getv61 = function()
        if v59 then
            local v60 = v58 < 7040
            return v60          
        else
            return false          
        end
    end
    local v61 = getv61()
    if v61 then
        local v62 = (v0)[(v58)+1]
        local v63 = v47 > v62
        if v63 then
            v0[(v58)+1] = v47            
            v1[(v58)+1] = v9            
            return nil                
        else
            -- return nil
        end
    else
        -- return nil
    end
end

function method3(v0, v1, v2, v3, v4, v5, v6)
    local v7 = -(v5)
    local v8 = { __tag = "Mut3", l0 = v7 }
    while method4(v5, v8) do
        local v10 = { __tag = "Mut3", l0 = v7 }
        while method5(v5, v10) do
            local v12 = v8 ~= nil and v8.l0
            local v13 = v10 ~= nil and v10.l0
            local v14 = 59
            method6(v0, v1, v2, v3, v4, v6, v12, v13, v7, v14)            
            local v15 = 92
            method6(v0, v1, v2, v3, v4, v6, v5, v13, v12, v15)            
            local v16 = -(v12)
            local v17 = 47
            method6(v0, v1, v2, v3, v4, v6, v7, v13, v16, v17)            
            local v18 = 61
            method6(v0, v1, v2, v3, v4, v6, v16, v13, v5, v18)            
            local v19 = -(v13)
            local v20 = 62
            method6(v0, v1, v2, v3, v4, v6, v12, v7, v19, v20)            
            local v21 = 60
            method6(v0, v1, v2, v3, v4, v6, v12, v5, v13, v21)            
            local v22 = v10 ~= nil and v10.l0
            local v23 = v22 + 0.6
            v10.l0 = v23
        end
        local v24 = v8 ~= nil and v8.l0
        local v25 = v24 + 0.6
        v8.l0 = v25
    end
    return nil                
end

function method7(v0)
    local v1 = v0 ~= nil and v0.l0
    local v2 = v1 < 44
    return v2          
end

function method8(v0)
    local v1 = v0 ~= nil and v0.l0
    local v2 = v1 < 160
    return v2          
end

function method2(v0, v1, v2, v3, v4, v5)
    local v6 = { __tag = "Mut0", l0 = 0 }
    while method0(v6) do
        local v8 = v6 ~= nil and v6.l0
        v0[(v8)+1] = 0.0            
        v1[(v8)+1] = 46            
        local v9 = v8 + 1
        v6.l0 = v9
    end
    local v10 = 20.0
    local v11 = -40.0
    method3(v0, v1, v2, v3, v4, v10, v11)            
    local v12 = 10.0
    local v13 = 10.0
    method3(v0, v1, v2, v3, v4, v12, v13)            
    local v14 = 5.0
    local v15 = 40.0
    method3(v0, v1, v2, v3, v4, v14, v15)            
    local v18 = "u001b[H"
    io.write(v18)            
    local v19 = { __tag = "Mut2", l0 = v5 }
    local v20 = { __tag = "Mut0", l0 = 0 }
    while method7(v20) do
        local v22 = v20 ~= nil and v20.l0
        local v23 = { __tag = "Mut0", l0 = 0 }
        while method8(v23) do
            local v25 = v23 ~= nil and v23.l0
            local v26 = v22 * 160
            local v27 = v25 + v26
            local v28 = (v1)[(v27)+1]
            local v29 = v28 == 59
            local getv47 = function()
                if v29 then
                    local v30 = ";"
                    return v30          
                else
                    local v31 = v28 == 92
                    if v31 then
                        local v32 = "\\"
                        return v32          
                    else
                        local v33 = v28 == 47
                        if v33 then
                            local v34 = "/"
                            return v34          
                        else
                            local v35 = v28 == 61
                            if v35 then
                                local v36 = "="
                                return v36          
                            else
                                local v37 = v28 == 62
                                if v37 then
                                    local v38 = ">"
                                    return v38          
                                else
                                    local v39 = v28 == 60
                                    if v39 then
                                        local v40 = "<"
                                        return v40          
                                    else
                                        local v41 = "."
                                        return v41          
                                    end
                                end
                            end
                        end
                    end
                end
            end
            local v47 = getv47()
            io.write(v47)            
            local v48 = v19 ~= nil and v19.l0
            local v49 = v48 * 31
            local v50 = v49 + v28
            local v51 = v50 % 1000003
            v19.l0 = v51
            local v52 = v25 + 1
            v23.l0 = v52
        end
        local v55 = "\n"
        io.write(v55)            
        local v56 = v22 + 1
        v20.l0 = v56
    end
    local v57 = v19 ~= nil and v19.l0
    return v57          
end

function method9(v0)
    local v1 = v0 >= 10
    if v1 then
        local v2 = v0 / 10
        method9(v2)            
    else
        -- return nil
    end
    local v3 = v0 % 10
    local v4 = v3 == 0
    local getv31 = function()
        if v4 then
            local v5 = "0"
            return v5          
        else
            local v6 = v3 == 1
            if v6 then
                local v7 = "1"
                return v7          
            else
                local v8 = v3 == 2
                if v8 then
                    local v9 = "2"
                    return v9          
                else
                    local v10 = v3 == 3
                    if v10 then
                        local v11 = "3"
                        return v11          
                    else
                        local v12 = v3 == 4
                        if v12 then
                            local v13 = "4"
                            return v13          
                        else
                            local v14 = v3 == 5
                            if v14 then
                                local v15 = "5"
                                return v15          
                            else
                                local v16 = v3 == 6
                                if v16 then
                                    local v17 = "6"
                                    return v17          
                                else
                                    local v18 = v3 == 7
                                    if v18 then
                                        local v19 = "7"
                                        return v19          
                                    else
                                        local v20 = v3 == 8
                                        if v20 then
                                            local v21 = "8"
                                            return v21          
                                        else
                                            local v22 = "9"
                                            return v22          
                                        end
                                    end
                                end
                            end
                        end
                    end
                end
            end
        end
    end
    local v31 = getv31()
    io.write(v31)            
    return nil                
end

local v0 = {}
local v1 = { __tag = "Mut0", l0 = 0 }
while method0(v1) do
    local v3 = v1 ~= nil and v1.l0
    v0[(v3)+1] = 0.0            
    local v4 = v3 + 1
    v1.l0 = v4
end
local v5 = {}
local v6 = { __tag = "Mut0", l0 = 0 }
while method0(v6) do
    local v8 = v6 ~= nil and v6.l0
    v5[(v8)+1] = 46            
    local v9 = v8 + 1
    v6.l0 = v9
end
local v10 = { __tag = "Mut1", l0 = 0.0, l1 = 0.0, l2 = 0.0 }
local v11 = { __tag = "Mut2", l0 = 0 }
local v12 = { __tag = "Mut0", l0 = 0 }
while method1(v12) do
    local v14 = v12 ~= nil and v12.l0
    local v15, v16, v17 = (table.unpack or unpack)(v10 ~= nil and v10.l0, v10 ~= nil and v10.l1, v10 ~= nil and v10.l2)
    local v18 = v11 ~= nil and v11.l0
    local v19 = method2(v0, v5, v15, v16, v17, v18)
    v11.l0 = v19
    local v20, v21, v22 = (table.unpack or unpack)(v10 ~= nil and v10.l0, v10 ~= nil and v10.l1, v10 ~= nil and v10.l2)
    local v23 = v20 + 0.05
    local v24 = v21 + 0.05
    local v25 = v22 + 0.01
    v10.l0 = v23
    v10.l1 = v24
    v10.l2 = v25
    local v26 = v14 + 1
    v12.l0 = v26
end
local v29 = "cube: "
io.write(v29)            
local v30 = 60
method9(v30)            
local v33 = " frames, checksum "
io.write(v33)            
local v34 = v11 ~= nil and v11.l0
method9(v34)            
local v35 = "\n"
io.write(v35)            
return 0          
